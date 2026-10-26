using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class CLS_UsuarioVista
    {
        public string Usuario { get; set; }
        public string Rol { get; set; }

        public CLS_UsuarioVista(string u, string rol)
        {
            Usuario = u;
            Rol = rol;
        }
    }
}
