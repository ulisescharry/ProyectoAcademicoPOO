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
    public partial class FormCambiarContraseña : Form
    {
        public FormCambiarContraseña(CLS_Usuario usuarioActual)
        {
            InitializeComponent();
            _usuario = usuarioActual;
        }
        private CLS_Usuario _usuario;
        private void btnCambiarCon_Click(object sender, EventArgs e)
        {
            string ConAct  =  txtContVieja.Text.Trim();
            string ConNue = txtNueCon.Text.Trim();
            string ConCon = txtConCon.Text.Trim();
            string hashAnt = CLS_Seguridad.EncriptarSHA256(ConAct);
            string hash = CLS_Seguridad.EncriptarSHA256(ConNue);
            if(_usuario._contraseñaHash != hashAnt)
            {
                MessageBox.Show("Contraseña actual no es correcta, no se puede completar la operación");
                return;
            }
            CLS_Usuario uMod = _usuario.Clone();
            uMod._contraseñaHash = hash;
            if(uMod.Equals(_usuario))
            {
                MessageBox.Show(Res.MessNoMod);
                return;
            }
            if(CLS_GestorUsuario.CambiarContraseña(uMod))
            {
                MessageBox.Show("Cambio de contraseña exitoso");
            }
            else
            {
                MessageBox.Show("Hubo problemas para cambiar la contraseña");
            }
        }

        private void FormCambiarContraseña_Load(object sender, EventArgs e)
        {
            texto();
        }

        private void texto()
        {
            label1.Text = Res.ConAct;
            label2.Text = Res.NueCon;
            label3.Text = Res.ConfNueCon;
            btnCambiarCon.Text = Res.CambCon;
        }
    }
}
