using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOOreal
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            Texto();
            string usuario = "admin";
            string contraseña = "admin123";
            string hash = CLS_Seguridad.EncriptarSHA256(contraseña);
            CLS_Usuario usuario1 = new CLS_Usuario(usuario,hash,0,"admin","apellido",123);
            if (!CLS_GestorUsuario.VerificarUsuario(usuario, contraseña))
            {
                CLS_ManejoCSV.EscribirEnCSV("usuarios.csv",usuario1);
            }
        }

        private void Texto()
        {
            label1.Text = Res.Usu;
            label2.Text = Res.Cont;
            button1.Text = Res.InSesion;
            label3.Text = Res.Idioma;
            Combo_Idioma.Text = Res.IdiomaAct;
            //cmo le cambio el nombre al formulario?
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = Txt_Usuario.Text;
            string contraseña = Txt_Contraseña.Text;
            if (string.IsNullOrEmpty(user) && string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show(Res.MessCampos);
            }
            bool registrado = CLS_GestorUsuario.VerificarUsuario(user, contraseña);
            if (!registrado)
            {
                MessageBox.Show(Res.MessUoCIncorr);
                return;
            }
             CLS_Usuario usuarioActual = CLS_GestorUsuario.ObtenerUsuario(user);
             CLS_Idioma.GuardarIdioma(CLS_Idioma.ObtenerIdiomaActual(), usuarioActual);
             FormComun f = new FormComun(usuarioActual);
             f.Show();
             this.Hide();


        }

        private void Combo_Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CLS_Idioma.CambiarIdioma(Combo_Idioma.SelectedIndex));        
            Texto();
        }
    }
}
