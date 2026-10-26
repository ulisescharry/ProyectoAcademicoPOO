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
    public partial class FormCargaEq : Form
    {
        public FormCargaEq( )
        {
            InitializeComponent();
        }
        private void FormUsuario_Load(object sender, EventArgs e)
        {
            gbJugador.Visible = false;
            gbEquipo.Visible = false;
            Texto();
        }

        private void Texto()
        {
            gbJugador.Text = Res.Jug;
            label1.Text = Res.NomEq;
            label2.Text = Res.Nom;
            label5.Text = Res.Ape;
            btnIniciarCarga.Text = Res.IniCargEq;
            btnCargar.Text = $"{Res.Carg} {Res.Jug}";
            Btn_CargEst.Text = $"{Res.Carg} {Res.Est}";
            lblNomEst.Text = Res.NomEst;
            lblCiudad.Text = Res.Ciudad;
        }
        CLS_Equipo equipoActual;
        int cantidadJugadores = 0;
        int idEquipo = 1;
        private void btnIniciarCarga_Click_1(object sender, EventArgs e)
        {
            if (txtNombreEquipo.Text.Trim() == "")
            {
                MessageBox.Show(Res.MessCampos);
                return;
            }
            if(File.Exists("Equipos.csv"))
            {
                List<CLS_Equipo> equiposExistentes = CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo());
                foreach (CLS_Equipo e1 in equiposExistentes)
                {
                    if (e1._nombreEquipo.Equals(txtNombreEquipo.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(Res.MessEqExist);
                        return;
                    }
                }
                idEquipo = equiposExistentes.Count + 1; // Ajusta el ID del equipo basado en la cantidad de equipos existentes
            }
            equipoActual = new CLS_Equipo(txtNombreEquipo.Text.Trim());
            equipoActual._IDEquipo = idEquipo;
            cantidadJugadores = 0;
            gbJugador.Visible = true;
            btnIniciarCarga.Enabled = false;
            idEquipo++;
            MessageBox.Show(Res.MessIniCarg);
        }
        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            if(File.Exists("Jugadores.csv"))
            {
                List<CLS_Jugador> jugadoresExistentes = CLS_ManejoCSV.LeerCSV("Jugadores.csv", new CLS_Jugador());
                foreach (CLS_Jugador j in jugadoresExistentes)
                {
                    if (j._dni == int.Parse(txt_dni.Text.Trim()))
                    {
                        MessageBox.Show(Res.MessDniExist);
                        return;
                    }
                }
            }
             string dni = txt_dni.Text.Trim();
            string nombre = txtNombreJugador.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            
            string[] campos = { nombre, apellido, dni };
            if (campos.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show(Res.MessCampos);
                return;
            }
            CLS_Jugador jugador = new CLS_Jugador(nombre,apellido,int.Parse(dni),equipoActual); 
            equipoActual._jugadores.Add(jugador);
            CLS_ManejoCSV.EscribirEnCSV("Jugadores.csv", jugador);
            cantidadJugadores++;

            MessageBox.Show($"{Res.Jug} {cantidadJugadores}{Res.MessConJug}");

            txtNombreJugador.Clear();
            txtApellido.Clear();
            txt_dni.Clear();

            if (cantidadJugadores == 5)
            {
                gbJugador.Visible = false;
                gbEquipo.Visible = true;
                txtNombreEquipo.Clear();
                txtNombreEquipo.Focus();
            }
        }

        private void txt_dni_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyCode)) // verifica si la tecla presionada no es un dígito
            {
                e.SuppressKeyPress = true; // evita que se registre la tecla presionada
            }
        }

        private void Btn_CargEst_Click(object sender, EventArgs e)
        {
            string nombreEstadio = txtnombrest.Text.Trim();
            string ciudad = txtCiudad.Text.Trim();
            int id = equipoActual._IDEquipo + 1000; // Genera un ID único para el estadio basado en el ID del equipo
            string[] campos = { nombreEstadio, ciudad };
            if (campos.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show(Res.MessCampos);
                return;
            }
            CLS_Estadio estadio = new CLS_Estadio(nombreEstadio, ciudad, id, equipoActual);
            equipoActual._estadio = estadio;
            CLS_ManejoCSV.EscribirEnCSV("Estadios.csv", estadio);
            CLS_ManejoCSV.EscribirEnCSV("Equipos.csv", equipoActual);
            MessageBox.Show(Res.MessEqCarg);
            gbEquipo.Visible = false;
            btnIniciarCarga.Enabled = true;
        }
    }
}