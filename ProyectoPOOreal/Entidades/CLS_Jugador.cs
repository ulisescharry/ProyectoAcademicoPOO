using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOOreal
{
    public class CLS_Jugador : CLS_Persona, IUsoCSV, ICloneable, IEquatable<CLS_Jugador>, IComparable<CLS_Jugador>
    {
        // Jugador pertenece a un equipo
        // Icomparable : va a ordenar por apellido
        // Icloneable: copia sin referencias
        // Rol por partido lo maneja Cls_Rolpartido(no se guarda aca)
        public CLS_Equipo _equipo { get; set; }
        public int _idEq {  get; set; }
        public void AsignarEquipo()
        {
            foreach(CLS_Equipo e in CLS_ManejoCSV.LeerCSV("Equipos.csv",new CLS_Equipo()))
            {
                if(e._IDEquipo == _idEq)
                {
                    _equipo = e; break;
                }
            }
        }

        // Constructores (sobrecarga)
        public CLS_Jugador() 
        {
        }
        public CLS_Jugador(string nombre, string apellido, int dni, CLS_Equipo equipo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _equipo = equipo;
        }

        public CLS_Jugador(string nombre, string apellido, int dni, CLS_Equipo equipo, string rol)
        : this(nombre, apellido, dni, equipo)
        {
        }

        // Polimorfismo

        public override int ObtenerId() => _dni;
        
        // Icomparable( por apellido)

        public int CompareTo(CLS_Jugador other)
        {
            if (other == null) return 1;
          
            return string.Compare(_apellido, other._apellido, StringComparison.OrdinalIgnoreCase);
        }

        // Icloneable

        public CLS_Jugador Clone()
        {
            return new CLS_Jugador
            {
                _nombre = this._nombre,
                _apellido = this._apellido,
                _dni = this._dni,
                _equipo = this._equipo // Referencia compartida, si se desea una copia profunda, se debería clonar el equipo también
            };
        }
        object ICloneable.Clone()
        {
            return Clone();
        }

        // IUsoCSV
        // Orden definido: Nombre;Apellido;DNI;Rol;Equipo
        public string LineaCSV()
        {
            // Si _equipo es null, usamos el _idEq suelto que se cargó al leer el archivo.
            // Si _equipo existe, usamos su ID real por seguridad.
            int idEquipoGuardar = (_equipo != null) ? _equipo._IDEquipo : _idEq;

            return $"{_nombre};{_apellido};{_dni};{idEquipoGuardar}";
        }
        public void CargarDesdeCSV(string[] partes)
        {
            if (partes.Length < 4) return;
            _nombre = partes[0].Trim();
            _apellido = partes[1].Trim();
            if (int.TryParse(partes[2].Trim(), out int dni)) _dni = dni;
            _idEq = int.Parse(partes[3]);
        }
        public string[] ObtenerEncabezadosCSV() => new[] { "Nombre", "Apellido", "DNI", "Equipo" };
        public string ObtenerIDCSV() => ObtenerId().ToString();

        public override string ToString() => $"{_apellido}, {_nombre} {_equipo._nombreEquipo}";

        //iequatable
        public bool Equals(CLS_Jugador other)
        {
            return this._nombre == other._nombre &&
                this._apellido == other._apellido &&
                this._dni == other._dni;
        }
    }
}
