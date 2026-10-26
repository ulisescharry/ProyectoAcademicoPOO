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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            dataGridView1.DataSource = ListaUsuarios;
        }
        BindingList<CLS_UsuarioVista> ListaUsuarios = new BindingList<CLS_UsuarioVista>();
        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            Texto();
            CLS_Usuario u = new CLS_Usuario(); //esto es para que el programa sepa que tipo de objeto va a leer del csv, sino tira error ¿hay alternativa?
            List <CLS_Usuario> usuarios = CLS_ManejoCSV.LeerCSV("usuarios.csv",u);
            foreach (CLS_Usuario user in usuarios)
            {
                CLS_UsuarioVista userVista = new CLS_UsuarioVista(user._usuario, user._rol);
                ListaUsuarios.Add(userVista);
            }
        }

        private void Texto()
        {
            label1.Text = Res.Usu;
            label3.Text = Res.Idioma;
            label4.Text = Res.Rol;
            groupBox1.Text = Res.NuevoU;
            Combo_Roles.Items.Clear();
            Combo_Roles.Items.Add(Res.Admin);
            Combo_Roles.Items.Add(Res.Coor);
            Combo_Roles.Items.Add(Res.Plani);
            Btn_Carga.Text = Res.CarU;
            Btn_Eliminar.Text = Res.EliU;
        }

        private void Combo_Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CLS_Idioma.CambiarIdioma(Combo_Idioma.SelectedIndex));
            Texto();
        }

        private void Btn_Carga_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Txt_Usuario.Text) && string.IsNullOrEmpty(txtdni.Text))
            {
                MessageBox.Show("Por favor, complete los campos necesarios");
            }
            else if (Combo_Roles.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un rol para el nuevo usuario");
            }
            else
            {
                string usuario = Txt_Usuario.Text;
                string dni = txtdni.Text;
                string año = DateTime.Now.Year.ToString();
                string contraseña = dni + año;
                foreach (CLS_UsuarioVista user in ListaUsuarios)
                {
                    if (user.Usuario == usuario)
                    {
                        MessageBox.Show("El nombre de usuario ya existe, por favor elija otro");
                        return;
                    }
                }
                int rol = Combo_Roles.SelectedIndex;
                string hash = CLS_Seguridad.EncriptarSHA256(contraseña);
                CLS_Usuario nuevoUsuario = new CLS_Usuario(usuario, hash, rol, "nombre", "apellido", int.Parse(dni));
                CLS_ManejoCSV.EscribirEnCSV("usuarios.csv",nuevoUsuario);
                CLS_UsuarioVista userVista = new CLS_UsuarioVista(usuario, nuevoUsuario._rol);
                ListaUsuarios.Add(userVista);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                var userSel = dataGridView1.CurrentRow.DataBoundItem as CLS_UsuarioVista;
                if(userSel == null)
                {
                    MessageBox.Show("null userSel"); return;
                }
                CLS_Usuario u = new CLS_Usuario(); //esto es para que el programa sepa que tipo de objeto va a leer del csv, sino tira error ¿hay alternativa?
                List<CLS_Usuario> usuarios = CLS_ManejoCSV.LeerCSV("usuarios.csv", u);
                foreach (CLS_Usuario user in usuarios)
                {
                    if(user._usuario.Equals(userSel.Usuario, StringComparison.OrdinalIgnoreCase))
                    {
                        CLS_ManejoCSV.EliminarObjetoCSV("usuarios.csv", user);
                        ListaUsuarios.Remove(userSel);
                        break;
                    }
                }
            }
        }
    }
}
