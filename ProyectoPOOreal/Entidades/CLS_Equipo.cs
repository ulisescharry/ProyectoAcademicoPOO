using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOOreal
{
    public class CLS_Equipo : IUsoCSV,IEquatable<CLS_Equipo>,ICloneable
    {
        public int _IDEquipo { get; set; }
        public string _nombreEquipo { get; set; }
        public CLS_Estadio _estadio { get; set; }
        private int _idEstadio { get; set; }

        public List<CLS_Jugador> _jugadores = new List<CLS_Jugador>();
        public void AsignarEstadio()
        {
            foreach (CLS_Estadio e in CLS_ManejoCSV.LeerCSV("Estadios.csv",new CLS_Estadio()))
            {
                if(e._IDEstadio == _idEstadio)
                {
                    _estadio = e;
                }
            }
            foreach (CLS_Jugador j in CLS_ManejoCSV.LeerCSV("Jugadores.csv", new CLS_Jugador()))
            {
                if (j._idEq == _IDEquipo)
                {
                    _jugadores.Add(j);  
                }
            }
        }
        public CLS_Equipo()
        {
        }
        public CLS_Equipo(string nombreEquipo, int id) //ctor para equipo libre
        {
            _nombreEquipo = nombreEquipo;
            _IDEquipo = id;
        }
        public CLS_Equipo(string nombreEquipo) //Ctor para creacion
        {
            _nombreEquipo = nombreEquipo;
        }
        public string LineaCSV()
        {
            // Si _estadio es null, usamos _idEstadio
            int idEstadioGuardar = (_estadio != null) ? _estadio._IDEstadio : _idEstadio;
            return $"{_IDEquipo};{_nombreEquipo};{idEstadioGuardar}";
        }

        public void CargarDesdeCSV(string[] partes)
        {
            if (partes.Length >= 4)
            {
                _IDEquipo = int.Parse(partes[0]);
                _nombreEquipo = partes[1].Trim();
                _idEstadio = int.Parse(partes[2]);
            }
        }

        public string[] ObtenerEncabezadosCSV()
        {
            return new string[] { "ID","Nombre", "Estadio"};
        }
        public string ObtenerIDCSV() => _IDEquipo.ToString();
        
        //implemento interfaz iequatable
        public bool Equals(CLS_Equipo other)
        {
            if (ReferenceEquals(this, other)) return true;
            return this._IDEquipo == other._IDEquipo &&
                this._nombreEquipo == other._nombreEquipo &&
                this._estadio.Equals(other._estadio);
        }
        //implemento interfaz iclonable
        public CLS_Equipo Clone()
        {
            CLS_Equipo e = new CLS_Equipo();
            e._IDEquipo = this._IDEquipo;
            e._nombreEquipo = this._nombreEquipo;
            e._jugadores = this._jugadores; //no hago clonación profunda porque no es relevante
            e._estadio = this._estadio!=null? this._estadio.Clone() : null;
            return e;
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
