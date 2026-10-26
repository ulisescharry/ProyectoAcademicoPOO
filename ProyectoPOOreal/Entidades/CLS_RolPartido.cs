using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class CLS_RolPartido : IUsoCSV
    {
        public int _idRolPartido { get; set; }
        public int _idPartido { get; set; }
        public int _idJugador { get; set; }   // DNI del jugador
        public Posicion _rol { get; set; }
        public enum Posicion { Arquero, Defensor, Mediocampista, Delantero }
        public CLS_Jugador _jugador { get; set; }
        public CLS_Partido _partido { get; set; }

        // Sobrecarga
        public CLS_RolPartido()
        {
            
        }
        public CLS_RolPartido(CLS_Jugador jugador, CLS_Partido partido, Posicion rol, int idRol) //id rol es un contador del 1 al 10
        {
            _jugador = jugador;
            _partido = partido;
            _idJugador = jugador._dni;
            _idPartido = partido._IDPartido;
            _rol = rol;
            _idRolPartido = partido._IDPartido * 100 + idRol;
        }
        // por id 
        public CLS_RolPartido(int idJugador, int idPartido, int rol)
        {
            _idJugador = idJugador;
            _idPartido = idPartido;
            _rol = ((Posicion)rol);
        }


        // IUsocsv

        public string LineaCSV() => $"{_idRolPartido};{_idPartido};{_idJugador};{_rol}";
        public void CargarDesdeCSV(string[] partes)
        {
            if (partes.Length < 4) return;
            if (int.TryParse(partes[0].Trim(), out int id)) _idRolPartido = id;
            if (int.TryParse(partes[1].Trim(), out int idP)) _idPartido = idP;
            if (int.TryParse(partes[2].Trim(), out int idJ)) _idJugador = idJ;
            _rol = (Posicion)Enum.Parse(typeof(Posicion), partes[3].Trim());
        }
        public string[] ObtenerEncabezadosCSV() => new[] { "IDRolPartido", "IDPartido", "IDJugador", "Rol" };
        public string ObtenerIDCSV() => _idRolPartido.ToString();
        public override string ToString() => $"Partido {_idPartido} | Jugador {_idJugador} | Rol: {_rol}";
    }
}
