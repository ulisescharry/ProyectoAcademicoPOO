using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOOreal
{
    public partial class FormModJug : Form
    {

        public FormModJug()
        {
            InitializeComponent();  
        }
        CLS_Jugador jugadorSel;
        List<CLS_Jugador> todosLosJugadores = CLS_ManejoCSV.LeerCSV("Jugadores.csv", new CLS_Jugador());
        private void FormModJug_Load(object sender, EventArgs e)
        {
            texto();
            // Llamamos al nuevo método que carga la grilla
            CargarJugadoresEnGrid();

        }

        private void CargarJugadoresEnGrid()
        {
            BindingList<CLS_JugadorVista> JVLista = new BindingList<CLS_JugadorVista>();

            foreach (CLS_Jugador j in todosLosJugadores)
            {
                j.AsignarEquipo();
                // Protección contra nulos por si un jugador no tiene equipo
                string NombreEq = j._equipo != null ? j._equipo._nombreEquipo : "Sin equipo";
                string nom = j._nombre;
                string ape = j._apellido;
                string dni = Convert.ToString(j._dni);

                CLS_JugadorVista jv = new CLS_JugadorVista(nom, ape, dni, NombreEq);
                JVLista.Add(jv);
            }

            // 2. Desvinculamos el DataGridView y lo volvemos a vincular para forzar el refresco
            dgvJugadores.DataSource = null;
            dgvJugadores.Rows.Clear();
            dgvJugadores.DataSource = JVLista;
        }

        private void texto()
        {
            lblNuevoNombre.Text = $"{Res.Nue} {Res.Nom}";
            lblNuevoApellido.Text = $"{Res.Nue} {Res.Ape}";
            lblNuevoDni.Text = $"{Res.Nue} {Res.DNI}";

            BtnOrdenar.Text = Res.OrdenarXA;
            btnModificar.Text = $"{Res.Mod}";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (jugadorSel == null) return;

            // PASO CLAVE: Guardamos el DNI viejo antes de clonar y modificar
            string idOriginal = jugadorSel.ObtenerIDCSV();

            CLS_Jugador jugMod = jugadorSel.Clone();
            jugMod._nombre = txtNombreMod.Text;
            jugMod._apellido = txtApellidoMod.Text;
            jugMod._dni = int.Parse(txtDNIMod.Text);

            if (jugMod.Equals(jugadorSel))
            {
                MessageBox.Show(Res.MessModIdi);
            }
            else
            {
                // Pasamos el jugMod (con el DNI nuevo) y el idOriginal (el DNI viejo)
                CLS_ManejoCSV.ModificarObjetoCSV("Jugadores.csv", jugMod, idOriginal);

                // ACTUALIZACIÓN VISUAL: Recargamos la grilla para ver los cambios
                CargarJugadoresEnGrid();
            }
        }

        private void dgvJugadores_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvJugadores.CurrentRow != null)
            {
                var jugSel= dgvJugadores.CurrentRow.DataBoundItem as CLS_JugadorVista;
                if(jugSel == null)
                {
                    MessageBox.Show("null JugSel"); return;
                }
                foreach (CLS_Jugador j in todosLosJugadores)
                {
                    if(j._dni == int.Parse(jugSel.DNI))
                    {
                        jugadorSel = j;
                        break;
                    }
                }
                txtNombreMod.Text = jugadorSel._nombre;
                txtApellidoMod.Text = jugadorSel._apellido;
                txtDNIMod.Text = Convert.ToString(jugadorSel._dni);
            }
        }

        private void txtDNIMod_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyCode)) // verifica si la tecla presionada no es un dígito
            {
                e.SuppressKeyPress = true; // evita que se registre la tecla presionada
            }
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            todosLosJugadores.Sort(); // Ordena usando IComparable implementado en CLS_Jugador
            CargarJugadoresEnGrid(); // Recargamos la grilla para reflejar el orden
        }
    }
}
