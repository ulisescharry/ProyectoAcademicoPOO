using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class CLS_Usuario : CLS_Persona, IUsoCSV,ICloneable,IEquatable<CLS_Usuario>
    {
        public string _usuario { get; set; }
        public string _contraseñaHash { get; set; }
        public string _rol { get; set; }
        public string _idioma { get; set; } = "es-ES";

        enum Rol
        {
            Administrador,
            Coordinador,
            Planillero
        }

        public CLS_Usuario(string usuario, string contraseña, int rol, string nombre, string apellido, int dni)
        {
            _usuario = usuario;
            _rol= ((Rol)rol).ToString();
            _contraseñaHash=contraseña;
            _nombre=nombre;
            _apellido=apellido;
            _dni = dni;
        }
        public CLS_Usuario()
        {
        }

        //implementación de IUsoCSV
        public string LineaCSV()
        {
            return $"{_dni};{_nombre};{_apellido};{_usuario};{_contraseñaHash};{_rol};{_idioma}";
        }
        public void CargarDesdeCSV(string[] partes)
        {
            if (partes.Length >= 7)
            {
                _dni = int.Parse(partes[0].Trim());
                _nombre = partes[1].Trim();
                _apellido = partes[2].Trim();
                _usuario = partes[3].Trim();
                _contraseñaHash = partes[4].Trim();
                _rol = partes[5].Trim();
                _idioma = partes[6].Trim();
            }
        }
        public string[] ObtenerEncabezadosCSV()
        {
            return new string[] { "DNI","Nombre","Apellido","Usuario", "ContraseñaHash", "Rol", "Idioma Preferido" };
        }
        public string ObtenerIDCSV() => ObtenerId().ToString();

        public CLS_Usuario Clone()
        {
            return new CLS_Usuario
            {
                _nombre = this._nombre,
                _apellido = this._apellido,
                _dni = this._dni,
                _contraseñaHash = this._contraseñaHash,
                _rol = this._rol,
                _usuario = this._usuario,
                _idioma = this._idioma
            };
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public bool Equals(CLS_Usuario other)
        {
            return this._nombre == other._nombre &&
            this._apellido == other._apellido &&
               this._dni == other._dni &&
               this._contraseñaHash == other._contraseñaHash;
        }
    }
}
