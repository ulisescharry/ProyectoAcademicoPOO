using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public static class CLS_Idioma
    {
        public static string CambiarIdioma(int idioma)
        {
            switch (idioma)
            {
                case 0:
                    return "";
                case 1:
                    return "en-US";
                default:
                    return "";
            }
        }
        public static string ObtenerIdiomaActual()
        {
            return System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
        }
        public static void GuardarIdioma(string idioma, CLS_Usuario u)
        {
            List<CLS_Usuario> usuarios = CLS_ManejoCSV.LeerCSV("usuarios.csv", new CLS_Usuario());
            foreach (CLS_Usuario user in usuarios)
            {
                if (user._dni == u._dni)
                {
                    if (user._idioma == idioma)
                    {
                        return;
                    }
                    else
                    {
                        user._idioma = idioma;
                        CLS_ManejoCSV.ModificarObjetoCSV("usuarios.csv", user);
                    }
                }
            }
        }
    }
}
