using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class CLS_Jornada : IUsoCSV
    {
        public List<CLS_Partido> _partidos = new List<CLS_Partido>();
        public int _numeroJornada { get; set; }
        public DateTime _fecha { get; set; }
        public CLS_Jornada(int n)
        {
            _numeroJornada = n;
        }
        public CLS_Jornada()
        {
        }
        public void AsignarObjetos()
        {
            _partidos.Clear();
            foreach (CLS_Partido partido in CLS_ManejoCSV.LeerCSV("Partidos.csv", new CLS_Partido()))
            {
                if(partido._IDPartido / 1000 == _numeroJornada)
                {
                    _partidos.Add(partido);
                }
            }
        }
        public string LineaCSV()
        {
            return $"{_numeroJornada};{_fecha.ToString("yyyy-MM-dd")}";
        }

        public void CargarDesdeCSV(string[] partes)
        {
            if (partes.Length >= 2)
            {
                _numeroJornada = int.TryParse(partes[0], out int nJ) ? nJ : 0;
                _fecha = DateTime.Parse(partes[1]);
            }
        }

        public string[] ObtenerEncabezadosCSV()
        {
            return new string[] { "Nro Jornada", "Fecha" };
        }

        public string ObtenerIDCSV()
        {
            return _numeroJornada.ToString();
        }

        public override string ToString()
        {
            return $"{_numeroJornada} {_fecha.ToString("MM-dd")}";
        }
    }
}
