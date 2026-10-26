using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOOreal
{
    public partial class FormPlanillero : Form
    {
        public FormPlanillero()
        {
            InitializeComponent();
        }

        private void FormPlanillero_Load(object sender, EventArgs e)
        {
            cmbTipoEvento.DataSource = Enum.GetValues(typeof(CLS_Evento.TipoEvento));
            cmbPosicion.DataSource = Enum.GetValues(typeof(CLS_RolPartido.Posicion));
            List<CLS_Jornada> jornadas = CLS_ManejoCSV.LeerCSV("Jornadas.csv", new CLS_Jornada());
            foreach(CLS_Jornada j in jornadas)
            {
                j.AsignarObjetos();
            }
            cmbJornadas.DataSource = jornadas;
            BtnIniRepro.Enabled = true;
            btnRegistrar.Enabled = false;
            btnFinalizar.Enabled = false;
            dateTimePicker1.Enabled = false;
            Texto();
        }

        private void Texto()
        {
            label1.Text = Res.LblPart;
            label2.Text = Res.LblJug;
            label3.Text = Res.LblTipEve;
            label4.Text = Res.LblMinEve;
            label5.Text = Res.LblCauEve;
            label6.Text = Res.LblJor;
            label7.Text = Res.LblPos;
            btnPosicion.Text = Res.BtnGuaPos;
            btnRegistrar.Text = Res.BtnRegEve;
            btnFinalizar.Text = Res.BtnFinCar;
            btnReprogPartido.Text = Res.SuspParti;
            BtnIniRepro.Text = Res.IniRepro;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CLS_Jugador jSel = cmbJugadores.SelectedItem as CLS_Jugador;

            if (partidoSel == null || jSel == null)
            {
                MessageBox.Show("Faltan seleccionar datos del partido o jugador.");
                return;
            }

            // Creamos el evento con los datos de la pantalla
            CLS_Evento.TipoEvento tipo = (CLS_Evento.TipoEvento)cmbTipoEvento.SelectedItem;
            CLS_Jugador autor = jSel;
            CLS_Partido partido = partidoSel;
            decimal minuto = nudMinuto.Value;
            string causa = txtCausa.Text;

            CLS_Evento nuevoEvento = new CLS_Evento(tipo,autor,partido,minuto,causa);

            // Generamos un ID
            nuevoEvento._idEvento = new Random().Next(1000, 9999);

            // Guardamos
            partidoSel.AgregarEvento(nuevoEvento);
            MessageBox.Show("Evento registrado exitosamente.");

            // Limpiamos los campos
            nudMinuto.Value = 0;
            txtCausa.Clear();
        }
        CLS_Partido partidoSel;
        private void cmbPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            partidoSel = cmbPartidos.SelectedItem as CLS_Partido;
            btnPosicion.Enabled = true;
            if (partidoSel != null && partidoSel._equipoL != null && partidoSel._equipoV != null)
            {
                //limpiamos pantalla y actualizamos
                listEventos.Items.Clear();
                lblResultado.Text = $"{partidoSel._equipoL._nombreEquipo} {partidoSel._golesEqL} - {partidoSel._equipoV._nombreEquipo} {partidoSel._golesEqV}";
                // Leemos todos los jugadores
                List<CLS_Jugador> todosLosJugadores = CLS_ManejoCSV.LeerCSV("Jugadores.csv", new CLS_Jugador());
                List<CLS_Jugador> jugadoresDelPartido = new List<CLS_Jugador>();

                foreach (CLS_Jugador j in todosLosJugadores)
                {
                    j.AsignarEquipo();
                    // Si el jugador pertenece al equipo Local o Visitante del partido seleccionado, lo agregamos
                    if (j._equipo != null &&
                       (j._equipo._IDEquipo == partidoSel._equipoL._IDEquipo ||
                        j._equipo._IDEquipo == partidoSel._equipoV._IDEquipo))
                    {
                        jugadoresDelPartido.Add(j);
                    }
                }
                ConJugPos = (partidoSel?._roles.Count ?? 0) + 1; //reseteamos variable global de posiciones
                cmbPosicion.Enabled = true;
                cmbJugadores.Enabled = true;
                BtnIniRepro.Enabled = true;
                // Refrescamos el ComboBox de jugadores
                cmbJugadores.DataSource = null;
                cmbJugadores.DataSource = jugadoresDelPartido;
            }
            if (partidoSel != null && partidoSel._registrado)
            {
                cmbPosicion.Enabled = false;
                cmbJugadores.Enabled = false;
                btnFinalizar.Enabled = false;
                btnRegistrar.Enabled = false;
                btnPosicion.Enabled = false;
                btnReprogPartido.Enabled = false;
                BtnIniRepro.Enabled = false;
                listEventos.Items.Clear();
                foreach (CLS_Evento evento in partidoSel._eventos)
                {
                    evento.AsignarObjetos();
                    ActualizarPantalla(evento);
                }
            }
        }

        private void cmbJornadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS_Jornada jornadaSel = cmbJornadas.SelectedItem as CLS_Jornada;
            if (jornadaSel == null) return;

            foreach (CLS_Partido p in jornadaSel._partidos)
            {
                p.AsignarObjetos();
                p.OnEventoRegistrado -= ActualizarPantalla; // saco la suscripción anterior si existía
                p.OnEventoRegistrado += ActualizarPantalla;
            }

            // Filtramos partidos que no tengan fechas libres
            List<CLS_Partido> partidosSinLibre = jornadaSel._partidos
                .Where(p => p._equipoL != null && p._equipoV != null &&
                            p._equipoL._nombreEquipo != "Libre" && p._equipoV._nombreEquipo != "Libre")
                .ToList();

            cmbPartidos.DataSource = null;
            cmbPartidos.DataSource = partidosSinLibre;
        }
        private void ActualizarPantalla(CLS_Evento evento)
        {
            listEventos.Items.Add(evento);
            lblResultado.Text = partidoSel.ToString();
        }

        int ConJugPos = 1;
        private void btnPosicion_Click(object sender, EventArgs e)
        {
            cmbPartidos.Enabled = false;
            cmbJornadas.Enabled = false;
            CLS_Jugador jugSel = cmbJugadores.SelectedItem as CLS_Jugador;
            CLS_RolPartido.Posicion pos = (CLS_RolPartido.Posicion)cmbPosicion.SelectedItem;
            if (jugSel == null || partidoSel == null) return;
            
            if (ConJugPos > 10)
            {
                MessageBox.Show("Ya se cargaron los 10 jugadores máximos para este partido.");
                cmbPosicion.Enabled = false;
                btnFinalizar.Enabled = true;
                btnRegistrar.Enabled = true;
                return;
            }

            bool yaCargado = partidoSel._roles.Any(r => r._idJugador == jugSel._dni);
            if (yaCargado)
            {
                MessageBox.Show("Ese jugador ya tiene una posición cargada en este partido.");
                return;
            }

            bool esLocal = partidoSel._equipoL._jugadores.Any(j => j._dni == jugSel._dni);

            bool yaTieneArquero = partidoSel._roles.Any(r =>
            {
                if (r._rol != CLS_RolPartido.Posicion.Arquero) return false;
                bool elRolEsDeLocal = partidoSel._equipoL._jugadores.Any(j => j._dni == r._idJugador);
                return esLocal ? elRolEsDeLocal : !elRolEsDeLocal;
            } );
            if (pos == CLS_RolPartido.Posicion.Arquero && yaTieneArquero)
            {
                MessageBox.Show($"{jugSel._equipo._nombreEquipo} ya tiene un arquero cargado para este partido.");
                return;
            }
            CLS_RolPartido rol = new CLS_RolPartido(jugSel, partidoSel, pos, ConJugPos);
            partidoSel._roles.Add(rol);
            ConJugPos++;
        }

        private void btnFinalizar_Click(object sender, EventArgs e) //logica de escritura en CSV
        {
            cmbPartidos.Enabled = true;
            cmbJornadas.Enabled = true;
            foreach(CLS_RolPartido r in partidoSel._roles)
            {
                CLS_ManejoCSV.EscribirEnCSV("RolesPartido.csv", r);
            }
            foreach(CLS_Evento ev in partidoSel._eventos)
            {
                CLS_ManejoCSV.EscribirEnCSV("Eventos.csv", ev);
            }
            partidoSel.AsignarObjetos();
            partidoSel._registrado = true;
            CLS_ManejoCSV.ModificarObjetoCSV("Partidos.csv", partidoSel);
        }

        private void cmbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS_Evento.TipoEvento Tipo = (CLS_Evento.TipoEvento)cmbTipoEvento.SelectedItem;
            if(Tipo == CLS_Evento.TipoEvento.Gol)
            {
                txtCausa.Enabled = false;
            }else
            {
                txtCausa.Enabled = true;
            }
        }

        private void btnReprogPartido_Click(object sender, EventArgs e)
        {
            if (partidoSel != null)
            {
                DateTime fechaSel = dateTimePicker1.Value;
                List<CLS_Partido> partidos = CLS_ManejoCSV.LeerCSV("Partidos.csv", new CLS_Partido());
                foreach (CLS_Partido p in partidos)
                {
                    p.AsignarObjetos();
                    if (p._fechayHora.Date.Equals(fechaSel.Date))
                    {
                        MessageBox.Show(Res.MessPartNoRepro);
                        return;
                    }
                }
                partidoSel._fechayHora = fechaSel.Date.Add(partidoSel._fechayHora.TimeOfDay);
                MessageBox.Show($"{Res.MessPartRepro} {fechaSel.ToShortDateString()}");
                CLS_ManejoCSV.ModificarObjetoCSV("Partidos.csv", partidoSel);
                dateTimePicker1.Enabled = false;
                btnReprogPartido.Enabled = false;
            }
        }

        private void BtnIniRepro_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            btnReprogPartido.Enabled = true;
            btnFinalizar.Enabled = false;
            btnPosicion.Enabled = false;
            btnRegistrar.Enabled = false;
        }
    }
}
