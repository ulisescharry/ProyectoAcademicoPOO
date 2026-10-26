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
    public partial class FormVerTablaPosiciones : Form
    {
        public FormVerTablaPosiciones()
        {
            InitializeComponent();
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void Texto()
        {
            btnActualizar.Text = Res.VerTablaPos;
            btnCampeon.Text = Res.DetCampeon;
        }

        private void CargarTabla()
        {
            try
            {
                List<CLS_Equipo> equipos =
                    CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo());

                List<CLS_Partido> partidos =
                    CLS_ManejoCSV.LeerCSV("Partidos.csv", new CLS_Partido());

                if (equipos == null || equipos.Count == 0)
                {
                    MessageBox.Show(
                        "Todavía no hay equipos cargados.",
                        "Sin datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    dgvPosiciones.DataSource = null;
                    return;
                }

                equipos = equipos
                    .Where(eq => eq._nombreEquipo != "Libre")
                    .ToList();

                Dictionary<int, FilaPosicion> tabla =
                    new Dictionary<int, FilaPosicion>();

                foreach (CLS_Equipo eq in equipos)
                {
                    tabla[eq._IDEquipo] = new FilaPosicion
                    {
                        Equipo = eq._nombreEquipo
                    };
                }

                if (partidos != null)
                {
                    foreach (CLS_Partido p in partidos)
                    {
                        if (!p._registrado)
                            continue;

                        if (!tabla.ContainsKey(p._idEqL) ||
                            !tabla.ContainsKey(p._idEqV))
                            continue;

                        FilaPosicion local = tabla[p._idEqL];
                        FilaPosicion visitante = tabla[p._idEqV];

                        local.PJ++;
                        visitante.PJ++;

                        local.GF += p._golesEqL;
                        local.GC += p._golesEqV;

                        visitante.GF += p._golesEqV;
                        visitante.GC += p._golesEqL;

                        if (p._golesEqL > p._golesEqV)
                        {
                            local.G++;
                            local.Pts += 3;
                            visitante.P++;
                        }
                        else if (p._golesEqV > p._golesEqL)
                        {
                            visitante.G++;
                            visitante.Pts += 3;
                            local.P++;
                        }
                        else
                        {
                            local.E++;
                            visitante.E++;

                            local.Pts++;
                            visitante.Pts++;
                        }
                    }
                }
                
                List<FilaPosicion> listaOrdenada = tabla.Values
                    .OrderByDescending(x => x.Pts)
                    .ThenByDescending(x => x.DG)
                    .ThenByDescending(x => x.GF)
                    .ThenBy(x => x.Equipo)
                    .ToList();

                for (int i = 0; i < listaOrdenada.Count; i++)
                {
                    listaOrdenada[i].Pos = i + 1;
                }

                dgvPosiciones.DataSource = null;
                dgvPosiciones.DataSource = listaOrdenada;

                dgvPosiciones.Columns["Pos"].HeaderText = "Pos.";
                dgvPosiciones.Columns["Equipo"].HeaderText = "Equipo";
                dgvPosiciones.Columns["PJ"].HeaderText = "PJ";
                dgvPosiciones.Columns["G"].HeaderText = "G";
                dgvPosiciones.Columns["E"].HeaderText = "E";
                dgvPosiciones.Columns["P"].HeaderText = "P";
                dgvPosiciones.Columns["GF"].HeaderText = "GF";
                dgvPosiciones.Columns["GC"].HeaderText = "GC";
                dgvPosiciones.Columns["DG"].HeaderText = "DG";
                dgvPosiciones.Columns["Pts"].HeaderText = "Pts";

                for (int i = 0;i < dgvPosiciones.Columns.Count;i++)
                {
                    dgvPosiciones.AutoResizeColumn(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la tabla: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private class FilaPosicion
        {
            public int Pos { get; set; }
            public string Equipo { get; set; }

            public int Pts { get; set; }
            public int PJ { get; set; }
            public int GF { get; set; }
            public int GC { get; set; }

            public int DG
            {
                get { return GF - GC; }
            }
            public int G { get; set; }
            public int E { get; set; }
            public int P { get; set; }
        }

        private void FormVerTablaPosiciones_Load(object sender, EventArgs e)
        {
            Texto();
        }

        private void btnCampeon_Click(object sender, EventArgs e)
        {
            List<CLS_Partido> partidos = CLS_ManejoCSV.LeerCSV("Partidos.csv", new CLS_Partido());
            foreach(CLS_Partido p in partidos)
            {
                p.AsignarObjetos();
            }
            partidos = partidos.Where(p => p._equipoL._nombreEquipo != "Libre" && p._equipoV._nombreEquipo != "Libre").ToList();
            string NomCampeon = dgvPosiciones.Rows[0].Cells[1].Value.ToString();
            bool todosJugados = partidos.All(p => p._registrado);
            if(todosJugados)
            {
                MessageBox.Show(Res.MessCampeon + NomCampeon);
            }else
            {
                MessageBox.Show(Res.MessPartNoRegis);
            }
        }
    }
}

