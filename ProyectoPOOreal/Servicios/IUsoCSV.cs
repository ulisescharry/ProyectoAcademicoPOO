using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    ///Interfaz para serialización / deserialización CSV.
    /// Todas las clases de dominio que se persisten la implementan.
    public interface IUsoCSV
    {
        string LineaCSV();
        void CargarDesdeCSV(string[] partes);
        string [] ObtenerEncabezadosCSV();
        string ObtenerIDCSV();
    }
}
