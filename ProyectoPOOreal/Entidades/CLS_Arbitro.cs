using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class CLS_Arbitro : CLS_Persona , IUsoCSV, ICloneable, IComparable<CLS_Arbitro>
    {
        public string _Matricula { get; set; }

        // Sobrecarga

        public CLS_Arbitro()
        {
            
        }
        public CLS_Arbitro(string nombre, string apellido, int dni, string matricula)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _Matricula = matricula;
        }


        // Polimorfismo

        public override int ObtenerId() => int.TryParse(_Matricula, out int m) ? m : _dni;

        // Icomparable

        public int CompareTo(CLS_Arbitro other)
        {
          if(other == null)  return 1;
          return string.Compare(_apellido, other._apellido, StringComparison.Ordinal);
        }

        // Icloneable

        public object Clone()
        {
            return new CLS_Arbitro
            {
                _nombre = this._nombre,
                _apellido = this._apellido,
                _dni = this._dni,
                _Matricula = this._Matricula,
            };
        }

        // IUsoCSV
        public string LineaCSV() => $"{_nombre};{_apellido};{_dni};{_Matricula}";
        

        public void CargarDesdeCSV(string[] partes)
        {
            if (partes.Length >= 4)
            {
                _nombre = partes[0].Trim();
                _apellido = partes[1].Trim();
                if (int.TryParse(partes[2].Trim(), out int dni)) _dni = dni;
                _Matricula = partes[3].Trim();
            }
        }

        public string[] ObtenerEncabezadosCSV() => new string[] { "Nombre", "Apellido", "DNI", "Matricula", "Estado" };
        public string ObtenerIDCSV() => ObtenerId().ToString();
        public override string ToString() => $"{_apellido}, {_nombre} - Mat: {_Matricula}";

     
    }
}
