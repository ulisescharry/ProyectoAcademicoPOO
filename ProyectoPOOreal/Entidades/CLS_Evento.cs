using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOOreal
{
    public class CLS_Evento : IUsoCSV
    {
        public enum TipoEvento { Gol, TarjetaRoja }
        public TipoEvento _tipo { get; set; }
        public CLS_Jugador _autor { get; set; }
        private int _dniAutor {  get; set; }
        public CLS_Equipo _eqAutor { get; set; }
        public CLS_Partido _partido { get; set; }
        public int _idPartido { get; set; }
        public decimal _minuto { get; set; }
        public string _causa { get; set; }
        public int _idEvento { get; set; }
        public CLS_Evento(TipoEvento t, CLS_Jugador j,CLS_Partido p ,decimal m, string c)
        {
            _tipo=t;
            _autor=j;
            _eqAutor = j._equipo;
            _partido = p;
            _minuto =m;
            _causa=c;
        }
        public CLS_Evento()
        {
        }
        public void AsignarObjetos()
        {
            foreach(CLS_Jugador j in CLS_ManejoCSV.LeerCSV("Jugadores.csv",new CLS_Jugador()))
            {
                j.AsignarEquipo();
                if(j._dni == _dniAutor)
                {
                    _autor = j;
                    _eqAutor = j._equipo;
                    break;
                }
            }
            foreach(CLS_Partido p in CLS_ManejoCSV.LeerCSV("Partidos.csv",new CLS_Partido()))
            {
                if(p._IDPartido == _idPartido)
                {
                    _partido = p; break;
                }
            }
        }
        public string LineaCSV()
        {
            return $"{_autor._nombre};{_autor._apellido};{_autor._dni};{_tipo};{_minuto};{_causa};{_partido._IDPartido};{_idEvento}" ;
        }

        public void CargarDesdeCSV(string[] partes)
        {
            if(partes.Length >= 8)
            {
                string nombre = partes[0].Trim();
                string apellido = partes[1].Trim();
                int dni = int.Parse(partes[2].Trim());
                _dniAutor = dni;
                _tipo = (TipoEvento)Enum.Parse(typeof(TipoEvento),partes[3].Trim());
                _minuto = decimal.TryParse(partes[4].Trim(), out decimal minutoParsed) ? minutoParsed : 0;
                _causa = partes[5].Trim();
                _idPartido = int.Parse(partes[6]);
                _idEvento = int.Parse(partes[7].Trim());
            }
        }

        public string[] ObtenerEncabezadosCSV()
        {
            return new string[] { "Nombre Autor", "Apellido Autor", "DNI Autor", "Tipo Evento", "Minuto", "Causa", "ID Partido", "ID Evento" };
        }
        public string ObtenerIDCSV() => _idEvento.ToString();

        public override string ToString()
        {
            return $"Min {_minuto}: {_autor._apellido} {_tipo}";
        }
    }

}
