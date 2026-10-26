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
    public partial class FormModEq : Form
    {
        public FormModEq()
        {
            InitializeComponent();
            List<CLS_Equipo> equipos = CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo());
            foreach(CLS_Equipo equipo in equipos)
            {
                equipo.AsignarEstadio();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = equipos;
            dgvEquipos.DataSource = bs;
        }
        CLS_Equipo equipoSel;
        private void FormModEq_Load(object sender, EventArgs e)
        {
            Texto();
        }

        private void Texto()
        {
            lblNomEq.Text = $"{Res.NomEq}";
            lblCiudad.Text = Res.Ciudad;
            lblNomEst.Text = Res.NomEst;
            gbEstadio.Text = Res.Est;
            btnElminar.Text = $"{Res.Eli} {Res.Eq}";
            btnModificar.Text = $"{Res.Mod} {Res.Eq}";
        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvEquipos.CurrentRow != null)
            {
                CLS_Equipo eq = dgvEquipos.CurrentRow.DataBoundItem as CLS_Equipo;
                if(eq != null)
                {
                    equipoSel = eq;
                    txtNomEq.Text = equipoSel._nombreEquipo;
                    txtCiudad.Text = equipoSel._estadio._ciudad;
                    txtNomEst.Text = equipoSel._estadio._nombre;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CLS_Equipo equipoMod = equipoSel.Clone();
            equipoMod._nombreEquipo = txtNomEq.Text;
            equipoMod._estadio._ciudad = txtCiudad.Text;
            equipoMod._estadio._nombre = txtNomEst.Text;
            if(equipoMod.Equals(equipoSel))
            {
                MessageBox.Show(Res.MessNoMod);
                CargarEquiposEnGrid();
            }
            else
            {
                CLS_ManejoCSV.ModificarObjetoCSV("Equipos.csv", equipoMod);
                CLS_ManejoCSV.ModificarObjetoCSV("Estadios.csv", equipoMod._estadio);
                CargarEquiposEnGrid();
            }
        }


        private void CargarEquiposEnGrid()
        {
            List < CLS_Equipo > equipos = CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo());
        
            foreach(CLS_Equipo equipo in equipos)
            {
                equipo.AsignarEstadio();
            }

            // 3. Refrescamos el DataSource
            dgvEquipos.DataSource = null; // Limpiamos la vinculación anterior
            dgvEquipos.DataSource = equipos; // Asignamos la lista nueva
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            if(equipoSel == null)
            {
                MessageBox.Show(Res.MessNoMod);
            }
            // 2. Leemos la lista actual de archivos
            List<CLS_Equipo> listaEquipos = CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo());

            // 3. Buscamos y removemos el equipo (usando el ID)
            // Usamos RemoveAll para quitar todos los que coincidan con el ID seleccionado
            listaEquipos.RemoveAll(eq => eq._IDEquipo == equipoSel._IDEquipo);

            // 4. SOBREESCRIBIR EL ARCHIVO: 
            
            // usamos un StreamWriter directamente aca para no alterar otras clases
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Equipos.csv", false))
                {
                    // Escribimos cabecera
                    sw.WriteLine("ID;Nombre;Estadio;Puntos");

                    foreach (CLS_Equipo eq in listaEquipos)
                    {
                        sw.WriteLine(eq.LineaCSV());
                    }
                }

                MessageBox.Show("Equipo eliminado correctamente.");
                CargarEquiposEnGrid(); // Refrescamos el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el equipo: " + ex.Message);
            }
        

        }
    }
}

