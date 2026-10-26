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
    public partial class FormComun : Form
    {
        public FormComun(CLS_Usuario usuarioActual)
        {
            InitializeComponent();
                if (usuarioActual._rol == "Administrador")
                {
                    administradorToolStripMenuItem.Visible = true;
                    coordinadorToolStripMenuItem.Visible = true;
                    planilleroToolStripMenuItem.Visible = true;
                }
                else if (usuarioActual._rol == "Coordinador")
                {
                    administradorToolStripMenuItem.Visible = false;
                    coordinadorToolStripMenuItem.Visible = true;
                    planilleroToolStripMenuItem.Visible = false;
                    
                }
                else if (usuarioActual._rol == "Planillero")
                {
                    administradorToolStripMenuItem.Visible = false;
                    coordinadorToolStripMenuItem.Visible = false;
                    planilleroToolStripMenuItem.Visible = true;
                    
                }
            string idioma = usuarioActual._idioma;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(idioma);
            _usuarioActual = usuarioActual;
        }
        CLS_Usuario _usuarioActual;
        private void FormComun_Load(object sender, EventArgs e)
        {
            Texto();
        }

        private void Texto()
        {
            administradorToolStripMenuItem.Text = Res.Admin;
            coordinadorToolStripMenuItem.Text = Res.Coor;
            planilleroToolStripMenuItem.Text = Res.Plani;
            cargarEquipoToolStripMenuItem.Text = Res.CargEqu;
            cargarÁrbitrosToolStripMenuItem.Text = Res.CargArb;
            verEquiposToolStripMenuItem.Text = Res.ModEq;
            verÁrbitrosToolStripMenuItem.Text = Res.ModArb;
            verJugadoresToolStripMenuItem.Text = Res.ModJug;
            cerrarSesiónToolStripMenuItem.Text = Res.CerrSesion;
            ayudaToolStripMenuItem.Text = Res.Ayuda;
            cambiarIdiomaPorDefectoToolStripMenuItem.Text = Res.ModIdi;
            españolToolStripMenuItem.Text = Res.Esp;
            inglésToolStripMenuItem.Text = Res.Ing;
            cambiarContraseñaToolStripMenuItem.Text = Res.CambCon;
            iniciarCampeonatoToolStripMenuItem.Text = Res.IniCamp;
            registrarEventosToolStripMenuItem.Text = Res.RegEventos;
            verTablaDePosicionesToolStripMenuItem.Text = Res.VerTablaPos;
            verTablaDePosicionesToolStripMenuItem1.Text = Res.VerTablaPos;
        }

        private void cargarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargaEq f = new FormCargaEq();
            f.MdiParent = this;
            f.Show();
        }

        private void cargarÁrbitrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargaAr f = new FormCargaAr();
            f.MdiParent = this;
            f.Show();
        }

        private void gestiónUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.MdiParent = this;
            f.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            this.Close();
            Inicio f = new Inicio();
            f.Show();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idiomaActual = CLS_Idioma.ObtenerIdiomaActual();
            if (idiomaActual != "es-MX")
            {
                CLS_Idioma.GuardarIdioma("es-MX", _usuarioActual);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
                MessageBox.Show(Res.MessModIdi);
                Texto();
            }else
            {
                MessageBox.Show(Res.MessIdiAct);
            }
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idiomaActual = CLS_Idioma.ObtenerIdiomaActual();
            if (idiomaActual != "en-US")
            {
                CLS_Idioma.GuardarIdioma("en-US", _usuarioActual);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                MessageBox.Show(Res.MessModIdi);
                Texto();
            }
            else
            {
                MessageBox.Show(Res.MessIdiAct);
            }
        }

        private void verEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModEq f = new FormModEq();
            f.MdiParent = this;
            f.Show();
        }

        private void verJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModJug f = new FormModJug();
            f.MdiParent = this;
            f.Show();
        }

        private void verÁrbitrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModAr f = new FormModAr();
            f.MdiParent = this;
            f.Show();
        }

        private void cambiarIdiomaPorDefectoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnIniCamp_Click(object sender, EventArgs e)
        {
            List<CLS_Arbitro> arb = CLS_ManejoCSV.LeerCSV("Arbitros.csv", new CLS_Arbitro());
            List<CLS_Equipo> eq = CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo());
            List<CLS_Estadio> est = CLS_ManejoCSV.LeerCSV("Estadios.csv", new CLS_Estadio());

        }

        private void registrarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlanillero f = new FormPlanillero();
            f.MdiParent = this;
            f.Show();
        }

        private void iniciarCampeonatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIniciarCamp f = new FormIniciarCamp();
            f.MdiParent = this;
            f.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCambiarContraseña f = new FormCambiarContraseña(_usuarioActual);
            f.MdiParent = this;
            f.Show();
        }

        private void verTablaDePosicionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVerTablaPosiciones f = new FormVerTablaPosiciones();
            f.MdiParent = this;
            f.Show();
        }

        private void verTablaDePosicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerTablaPosiciones f = new FormVerTablaPosiciones();
            f.MdiParent = this;
            f.Show();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
