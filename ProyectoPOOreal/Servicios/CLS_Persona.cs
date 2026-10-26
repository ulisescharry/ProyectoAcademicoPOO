using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public abstract class CLS_Persona
    {
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public int _dni { get; set; }

        /// Devuelve el identificador principal de la persona.
        ///  Las subclases pueden sobreescribirlo para devolver su propio ID específico.

        public virtual int ObtenerId() => _dni;

        public override string ToString() => $"{_apellido}, {_nombre} (DNI: {_dni})";


    }
}
