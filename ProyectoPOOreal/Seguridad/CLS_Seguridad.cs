using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public static class CLS_Seguridad
    {
        public static string EncriptarSHA256(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertimos la cadena en un array de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));

                // Convertimos el array de bytes a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public static bool VerificarPassword(string passwordIngresada, string hashAlmacenado)
        {
            // 1. Encriptamos la contraseña que el usuario acaba de escribir
            string hashIngresado = EncriptarSHA256(passwordIngresada);

            // 2. Comparamos los dos hashes (ignora mayúsculas/minúsculas por seguridad)
            return string.Equals(hashIngresado, hashAlmacenado, StringComparison.OrdinalIgnoreCase);
        }
    }

}
