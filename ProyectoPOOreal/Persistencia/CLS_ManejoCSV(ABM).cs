using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOOreal
{
    public static class CLS_ManejoCSV
    {
        public static List<T> LeerCSV<T>(string ruta, T objeto) where T : IUsoCSV, new()
        {
            List<T> listaObjetos = new List<T>();
            try
            {
                if (!File.Exists(ruta)) return listaObjetos;

                using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    // 1. Leemos y descartamos ÚNICAMENTE la primera línea (Encabezados)
                    sr.ReadLine();

                    // 2. Leemos la primera línea de DATOS reales
                    string linea = sr.ReadLine();

                    while (linea != null)
                    {
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            string[] partes = linea.Split(';');
                            T nuevoObjeto = new T();
                            nuevoObjeto.CargarDesdeCSV(partes);
                            listaObjetos.Add(nuevoObjeto);
                        }
                        linea = sr.ReadLine(); // Siguiente línea de datos
                    }
                }
                return listaObjetos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo " + ruta + ": " + ex.Message);
                return listaObjetos;
            }
        }


        public static void EscribirEnCSV<T>(string ruta, T objeto) where T : IUsoCSV, new()
        {
            try
            {
                bool archivoExiste = File.Exists(ruta);

                using (FileStream fs = new FileStream(ruta, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    // Si el archivo es nuevo, escribimos primero la fila de encabezados
                    if (!archivoExiste)
                    {
                        string[] encabezados = objeto.ObtenerEncabezadosCSV();
                        sw.WriteLine(string.Join(";", encabezados));
                    }

                    // Escribimos los datos del nuevo objeto
                    sw.WriteLine(objeto.LineaCSV());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir en el archivo " + ruta + ": " + ex.Message);
            }
        }
        private static void EscribirListaCSV<T>(string ruta, List<T> listaObjetos) where T : IUsoCSV, new()
        {
            using (FileStream fs = new FileStream(ruta, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                T temp = new T();
                string[] enca = temp.ObtenerEncabezadosCSV();
                sw.WriteLine(string.Join(";", enca));

                foreach (T objeto in listaObjetos)
                {
                    sw.WriteLine(objeto.LineaCSV());
                }
            }
        }
        public static void ModificarObjetoCSV<T>(string ruta, T objetoMod, string idOriginal = null) where T : IUsoCSV, new()
        {
            try
            {
                List<T> listaObjetos = LeerCSV(ruta, objetoMod);

                // Si se envía un idOriginal (el viejo), buscamos por ese. Si es null, usamos el ID actual del objeto.
                string idBuscado = idOriginal ?? objetoMod.ObtenerIDCSV();
                bool encontrado = false;

                for (int i = 0; i < listaObjetos.Count; i++)
                {
                    if (listaObjetos[i].ObtenerIDCSV() == idBuscado)
                    {
                        listaObjetos[i] = objetoMod;
                        encontrado = true;
                        break;
                    }
                }

                // Si se modificó el objeto (o no se encontró pero se quiere asegurar la persistencia), reescribimos el archivo completo
                if (encontrado || idOriginal == null)
                {
                    EscribirListaCSV(ruta, listaObjetos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el objeto en " + ruta + ": " + ex.Message);
            }
        }

        public static void EliminarArchivo(string archivo)
        {
            try
            {
                if (File.Exists(archivo))
                {
                    File.Delete(archivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el archivo " + archivo + ": " + ex.Message);
            }
        }

        public static void EliminarObjetoCSV<T>(string ruta, T objeto) where T : IUsoCSV, new()
        {
            List<T> listaObjetos = LeerCSV(ruta, objeto);
            listaObjetos.RemoveAll(o => o.ObtenerIDCSV() == objeto.ObtenerIDCSV());
            EscribirListaCSV(ruta, listaObjetos);
        }
    }
}
