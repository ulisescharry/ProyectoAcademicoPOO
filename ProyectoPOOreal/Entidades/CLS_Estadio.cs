using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class CLS_Estadio : ICloneable, IUsoCSV, IEquatable<CLS_Estadio>
    {
        // Implementamos Icloneable para poder copiarlo sin referencias.
        public string _nombre { get; set; }
        public int _IDEstadio { get; set; }
        public CLS_Equipo _eqLocal { get; set; }
        public string _ciudad { get; set; }
        public CLS_Estadio()
        {
                
        }
        public CLS_Estadio(string nombre, string ciudad, int id, CLS_Equipo eq)
        {
            _nombre = nombre;
            _ciudad = ciudad;
            _IDEstadio = id;
            _eqLocal = eq;
        }

        public CLS_Estadio(int id, CLS_Equipo eq)
        {
            _nombre = "Libre";
            _ciudad = "Ninguna";
            _IDEstadio = id;
            _eqLocal = eq;
        }

        // ICloneable
        public CLS_Estadio Clone()
        {
           return new CLS_Estadio
           {
               _nombre = this._nombre,
               _IDEstadio = this._IDEstadio,
               _ciudad = this._ciudad
           };
        }
        object ICloneable.Clone()
        {
            return Clone();
        }

        // IUsoCSV
        public string LineaCSV()
        {
            // Si no hay equipo asignado, guardamos un texto de seguridad
            string nombreEquipoGuardar = (_eqLocal != null) ? _eqLocal._nombreEquipo : "Sin Equipo";
            return $"{_IDEstadio};{_nombre};{_ciudad};{nombreEquipoGuardar}";
        }

        public void CargarDesdeCSV(string[] partes)
        {
            if (partes.Length >= 4)
            {
                if (int.TryParse(partes[0].Trim(), out int id)) _IDEstadio = id;
                _nombre = partes[1].Trim();
                _ciudad = partes[2].Trim();
                foreach (CLS_Equipo e in CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo()))
                {
                    if (e._nombreEquipo.Equals(partes[3].Trim()))
                    {
                        _eqLocal = e;
                        break;
                    }
                }
            }
        }
     

        public string[] ObtenerEncabezadosCSV() => new[] { "IDEstadio", "Nombre", "Ciudad" , "Equipo" };
        public string ObtenerIDCSV() => _IDEstadio.ToString();
        public override string ToString() => _nombre;
        //Iequatable
        public bool Equals(CLS_Estadio other)
        {
            
            if (other == null) return false;
            return this._IDEstadio == other._IDEstadio &&
                this._nombre == other._nombre &&
                this._ciudad == other._ciudad;                                
        }
    }
}
