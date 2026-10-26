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
    public partial class FormCoordinador : Form
    {
        public FormCoordinador()
        {
            InitializeComponent();
        }

        private void FormCoordinador_Load(object sender, EventArgs e)
        {
            Texto();
        }

        private void Texto()
        {
            cmb_idioma.Text = Res.IdiomaAct;
            lbl_idioma.Text = Res.Idioma;
            btn_equipo.Text = Res.CargEqu;
            btn_arbitro.Text = Res.CargArb;
            btn_estadio.Text = Res.CargEst;
        }

        private void btn_equipo_Click(object sender, EventArgs e)
        {
            FormCargaEq fequipo = new FormCargaEq();
            fequipo.MdiParent = this;
            fequipo.Show();
        }

        private void btn_arbitro_Click(object sender, EventArgs e)
        {
            FormCargaAr farbitro = new FormCargaAr();
            farbitro.MdiParent = this;
            farbitro.Show();
        }

        private void cmb_idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CLS_Idioma.CambiarIdioma(cmb_idioma.SelectedIndex));
            Texto();
        }

        private void Btn_IniCamp_Click(object sender, EventArgs e)
        {

        }
    }
}
