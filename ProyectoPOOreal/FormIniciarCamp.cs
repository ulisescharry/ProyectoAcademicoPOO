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
    public partial class FormIniciarCamp : Form
    {
        public FormIniciarCamp()
        {
            InitializeComponent();
        }
        private void CargarFixtureEnGrid(List<CLS_Partido> listaDePartidos)
        {
            // 1. Limpiamos cualquier dato previo que tenga el Grid
            dgvPartidos.DataSource = null;
            btnIniCamp.Enabled = false;
            // 2. Usamos LINQ (.Select) para transformar la lista compleja en una estructura plana y legible
            var datosAplanados = listaDePartidos.Select(p => new
            {
                ID = p._IDPartido,
                Fecha = p._fechayHora.ToString("dd/MM/yyyy"),
                Hora = p._fechayHora.ToString("HH:mm"),

                // Si el equipo local es nulo o se llama Libre, mostramos "Libre", sino su nombre real
                Local = p._equipoL != null ? p._equipoL._nombreEquipo : "Libre",
                GolesL = p._golesEqL,

                GolesV = p._golesEqV,
                Visitante = p._equipoV != null ? p._equipoV._nombreEquipo : "Libre",

                // Validamos que el estadio no sea nulo antes de mostrarlo
                Estadio = p._estadio != null ? p._estadio.ToString() : "Sin Estadio",

                // Validamos que el árbitro no sea nulo para evitar que el programa explote
                Arbitro = p._arbitro != null ? p._arbitro.ToString() : "Sin Árbitro"
            }).ToList();

            // 3. Le asignamos los datos procesados al DataGridView
            dgvPartidos.DataSource = datosAplanados;

            // 4. Detalle visual: Ajustamos las columnas automáticamente para que se lea perfecto
            dgvPartidos.AutoResizeColumns();
        }
        private void btnIniCamp_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Instanciamos el objeto campeonato
                CLS_Campeonato campeonato = new CLS_Campeonato();

                // 2. Cargamos las listas desde tus archivos CSV usando tu CLS_ManejoCSV
                campeonato._equipos = CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo());
                campeonato._arbitros = CLS_ManejoCSV.LeerCSV("Arbitros.csv", new CLS_Arbitro());
                campeonato._estadios = CLS_ManejoCSV.LeerCSV("Estadios.csv", new CLS_Estadio());
                // (Si tus equipos necesitan enlazar sus estadios antes, recordá llamar a equipo.AsignarEstadio())
                foreach (var eq in campeonato._equipos)
                {
                    eq.AsignarEstadio();
                }

                // 3. Ejecutamos
                campeonato.IniciarCampeonato();

                // 5. Opcional: Actualizamos el archivo de Equipos por si se modificaron puntos a 0
                foreach (CLS_Equipo eq in campeonato._equipos)
                {
                    if (eq._nombreEquipo != "Libre")
                    {
                        CLS_ManejoCSV.ModificarObjetoCSV("Equipos.csv", eq);
                    }
                }
                CargarFixtureEnGrid(campeonato._partidos);
                MessageBox.Show("¡Campeonato iniciado con éxito de forma local y fixture guardado en el sistema!");
            }
            catch (EXC_CantArb exCustom)
            {
                MessageBox.Show($"Error de negocio: {exCustom.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
            MessageBox.Show("¡El campeonato ha comenzado y el fixture fue generado!");
        }

        private void FormIniciarCamp_Load(object sender, EventArgs e)
        {
            btnIniCamp.Text = Res.IniCamp;
            if(File.Exists("Partidos.csv"))
            {
                List<CLS_Partido> partidos = CLS_ManejoCSV.LeerCSV("Partidos.csv", new CLS_Partido());
                foreach (var par in partidos)
                {
                    par.AsignarObjetos();
                }
                CargarFixtureEnGrid(partidos);
            }
            btnIniCamp.Enabled =true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string[] archivosCampeonato = { "Partidos.csv", "Jornadas.csv", "Eventos.csv", "RolesPartido.csv", "Equipos.csv", "Estadios.csv", "Arbitros.csv", "Jugadores.csv" };

            foreach (string archivo in archivosCampeonato)
            {
                CLS_ManejoCSV.EliminarArchivo(archivo);
            }
        }
    }
}
