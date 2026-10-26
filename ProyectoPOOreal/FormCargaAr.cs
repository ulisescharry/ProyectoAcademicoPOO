using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoPOOreal
{
    public partial class FormCargaAr : Form
    {
        public FormCargaAr()
        {
            InitializeComponent();
        }

        private void FormCargaAr_Load(object sender, EventArgs e)
        {
            Texto();
        }

        private void Texto()
        {
            lblNombre.Text = Res.Nom;
            lblApellido.Text = Res.Ape;
            lblMatricula.Text = Res.Matricula;
            gbArbitro.Text = Res.Arb;
            btnCargar.Text = $"{Res.Carg} {Res.Arb}";
            if (File.Exists("Arbitros.csv"))
            {
                List<CLS_Arbitro> aExst = CLS_ManejoCSV.LeerCSV("Arbitros.csv", new CLS_Arbitro());
                dataGridView1.DataSource = aExst;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (File.Exists("Arbitros.csv"))
            {
                List<CLS_Arbitro> arbitrosExistentes = CLS_ManejoCSV.LeerCSV("Arbitros.csv", new CLS_Arbitro());
                foreach (CLS_Arbitro a in arbitrosExistentes)
                {
                    if (a._Matricula == txt_matricula.Text)
                    {
                        MessageBox.Show(Res.MessMatExist); return;
                    }
                }
            }
            string[] campos = { txtApellido.Text, txtNombre.Text, txt_matricula.Text, txt_dni.Text };
            if (campos.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show(Res.MessCampos);
                return;
            }
            string apellido = campos[0];
            string nombre = campos[1];
            string matricula = campos[2];
            int dni = int.Parse(campos[3]);
            CLS_Arbitro arbitro = new CLS_Arbitro(nombre, apellido, dni, matricula);
            CLS_ManejoCSV.EscribirEnCSV("Arbitros.csv", arbitro);
            Texto();
        }

        private void txt_dni_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyCode)) // verifica si la tecla presionada no es un dígito
            {
                e.SuppressKeyPress = true; // evita que se registre la tecla presionada
            }
        }

        private void txt_matricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyCode)) // verifica si la tecla presionada no es un dígito
            {
                e.SuppressKeyPress = true; // evita que se registre la tecla presionada
            }
        }
    }
}
