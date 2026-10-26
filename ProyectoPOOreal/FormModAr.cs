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
    public partial class FormModAr : Form
    {
        CLS_Arbitro arbitroSel;
        public FormModAr()
        {
            InitializeComponent();
        }

        private void FormModAr_Load(object sender, EventArgs e)
        {
            CargarArbitrosEnGrid();
            // Vinculamos el evento de selección
            dgvArbitros.SelectionChanged += dgvArbitros_SelectionChanged;

            lblNuevoNombre.Text = $"{Res.Nue} {Res.Nom}";
            lblNuevoApellido.Text = $"{Res.Nue} {Res.Ape}";
            lblNuevoDni.Text = $"{Res.Nue} {Res.DNI}";

            btnModificar.Text = $"{Res.Mod}";
            BtnOrdenar.Text = Res.OrdenarXA;
        }
        List<CLS_Arbitro> todosLosArb = CLS_ManejoCSV.LeerCSV("Arbitros.csv", new CLS_Arbitro());
        private void CargarArbitrosEnGrid()
        {
            dgvArbitros.DataSource = null;
            dgvArbitros.DataSource = todosLosArb;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (arbitroSel == null)
            {
                MessageBox.Show("Seleccione un árbitro de la lista.");
                return;
            }

            // 1. Clonamos el objeto para modificarlo
            CLS_Arbitro arbMod = (CLS_Arbitro)arbitroSel.Clone();

            // 2. Asignamos los nuevos valores desde los TextBox
            arbMod._nombre = txtNombreMod.Text;
            arbMod._apellido = txtApellidoMod.Text;

            if (int.TryParse(txtDNIMod.Text, out int nuevoDni))
            {
                arbMod._dni = nuevoDni;
            }

            // 3. Guardamos los cambios en el CSV
            CLS_ManejoCSV.ModificarObjetoCSV("Arbitros.csv", arbMod);

            // 4. Refrescamos la grilla
            CargarArbitrosEnGrid();

            MessageBox.Show("Árbitro modificado correctamente.");
        }

        private void dgvArbitros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvArbitros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArbitros.CurrentRow != null)
            {
                
                arbitroSel = dgvArbitros.CurrentRow.DataBoundItem as CLS_Arbitro;
                if (arbitroSel != null)
                {
                    txtNombreMod.Text = arbitroSel._nombre;
                    txtApellidoMod.Text = arbitroSel._apellido;
                    txtDNIMod.Text = arbitroSel._Matricula;
                    
                }
            }
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            todosLosArb.Sort();
            CargarArbitrosEnGrid();
        }
    }
}
