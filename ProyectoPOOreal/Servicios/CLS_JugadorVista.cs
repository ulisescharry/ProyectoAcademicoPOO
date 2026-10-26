using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public  class CLS_JugadorVista
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Equipo { get; set; }

        public CLS_JugadorVista(string n, string a, string dni, string e)
        {
            Nombre = n;
            Apellido = a;
            DNI = dni;
            Equipo = e;
        }
    }
}
