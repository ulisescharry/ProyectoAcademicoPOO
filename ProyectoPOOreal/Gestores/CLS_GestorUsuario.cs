using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOOreal
{
    public static class CLS_GestorUsuario
    {
        public static void RegistrarUsuario(CLS_Usuario user)   //sacarlo? menuadmin linea 70 inicio linea 30
        {
            CLS_ManejoCSV.EscribirEnCSV("usuarios.csv",user);
        }
        public static bool VerificarUsuario(string user, string contraseña)
        {
            string hash = CLS_Seguridad.EncriptarSHA256(contraseña);
            CLS_Usuario u1 = new CLS_Usuario(); //esto es para que el programa sepa que tipo de objeto va a leer del csv, sino tira error ¿hay alternativa?
            List<CLS_Usuario> usuarios = CLS_ManejoCSV.LeerCSV("usuarios.csv",u1);
            foreach (CLS_Usuario u in usuarios)
            {
                if (u._usuario.Equals(user, StringComparison.OrdinalIgnoreCase))
                {
                    if(u._contraseñaHash.Equals(hash))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static string ObtenerRolUsuario(string user)
        {
            CLS_Usuario u1 = new CLS_Usuario();
            List<CLS_Usuario> usuarios = CLS_ManejoCSV.LeerCSV("usuarios.csv", u1);
            foreach (CLS_Usuario u in usuarios)
            {
                if (u._usuario.Equals(user, StringComparison.OrdinalIgnoreCase))
                {
                    return u._rol;
                }
            }
            return "Usuario no encontrado";
        }

        public static CLS_Usuario ObtenerUsuario(string user)
        {
            CLS_Usuario u1 = new CLS_Usuario(); //esto es para que el programa sepa que tipo de objeto va a leer del csv, sino tira error ¿hay alternativa?
            List<CLS_Usuario> usuarios = CLS_ManejoCSV.LeerCSV("usuarios.csv", u1);
            foreach (CLS_Usuario u in usuarios)
            {
                if (u._usuario.Equals(user, StringComparison.OrdinalIgnoreCase))
                {
                    return u;
                }
            }
            return null;
        }
        public static bool CambiarContraseña(CLS_Usuario uMod)
        {
            List<CLS_Usuario> usuarios = CLS_ManejoCSV.LeerCSV("usuarios.csv", uMod);
            foreach (CLS_Usuario u in usuarios)
            {
                if(u._usuario == uMod._usuario)
                {
                    CLS_ManejoCSV.ModificarObjetoCSV("usuarios.csv", uMod);
                    return true;
                }
            }
            return false;
        }
    }
}
