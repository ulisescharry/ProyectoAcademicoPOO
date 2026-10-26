using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class CLS_Campeonato
    {
        public List<CLS_Equipo> _equipos = new List<CLS_Equipo>();
        public List<CLS_Arbitro> _arbitros = new List<CLS_Arbitro>();
        public List<CLS_Estadio> _estadios = new List<CLS_Estadio>();
        public List<CLS_Partido> _partidos = new List<CLS_Partido>();
        public List<CLS_Jornada> _jornadas = new List<CLS_Jornada>();
        public List<CLS_Evento> _eventos = new List<CLS_Evento>();
        private int _idP = 1;

        public void IniciarCampeonato()
        {

            // Añadir equipo libre si son impares
            if (_equipos.Count % 2 != 0)
            {
                CLS_Equipo eqLibre = new CLS_Equipo("Libre", _equipos.Count + 1);
                _equipos.Add(eqLibre);
                CLS_Estadio esLibre = new CLS_Estadio(_estadios.Count + 1001, eqLibre); //revisar asignación de id, no funciona, creo que _estadios.Count da 0
                _estadios.Add(esLibre);
                eqLibre._estadio = esLibre;
                CLS_ManejoCSV.EscribirEnCSV("Equipos.csv", eqLibre);
                CLS_ManejoCSV.EscribirEnCSV("Estadios.csv", esLibre);
            }

            _partidos.Clear();
            _jornadas.Clear();

            int cantidadJornadas = _equipos.Count - 1;
            int partidosPorJornada = _equipos.Count / 2;

            // Validación de árbitros mínimos necesarios para cubrir una jornada en simultáneo
            if (_arbitros.Count < partidosPorJornada)
            {
                throw new EXC_CantArb(partidosPorJornada, _arbitros.Count);
            }

            // --- PASO A: GENERAR TODA LA PRIMERA VUELTA ---
            List<CLS_Equipo> rotables = _equipos.Take(_equipos.Count - 1).ToList();
            CLS_Equipo fijo = _equipos[_equipos.Count - 1];
            for (int ContJornada = 0; ContJornada < cantidadJornadas; ContJornada++)
            {
                int NumJornada = ContJornada + 1;
                CLS_Jornada nuevaJornada = new CLS_Jornada(NumJornada);
                DateTime fecha = DateTime.Now.AddDays(7 * NumJornada); // Cada jornada se programa una semana después de la anterior, primer jornada despues de una semana desde el inicio del campeonato
                nuevaJornada._fecha = fecha;
                for (int i = 0; i < partidosPorJornada; i++)
                {
                    CLS_Equipo local, visitante;
                    if (i == 0)
                    {
                        local = fijo;

                        visitante = rotables[0];   // par del fijo: siempre el primero de rotables
                    }
                    else
                    {
                        local = rotables[i];                    // de adentro hacia afuera
                        visitante = rotables[rotables.Count - i];   // espejo
                    }

                    CLS_Partido nuevoPartido = new CLS_Partido(local, visitante);
                    TimeSpan hora = TimeSpan.FromHours( i * 2);
                    nuevoPartido._fechayHora = fecha + hora;
                    nuevoPartido._estadio = nuevoPartido._equipoL._estadio;
                    nuevoPartido._IDPartido = NumJornada * 1000 + _idP;
                    _idP++;

                    _partidos.Add(nuevoPartido);
                    nuevaJornada._partidos.Add(nuevoPartido);
                }
                CLS_Equipo ultimo = rotables[rotables.Count - 1];
                rotables.RemoveAt(rotables.Count - 1);
                rotables.Insert(0, ultimo);
                _jornadas.Add(nuevaJornada);
            } 

            // --- PASO B: GENERAR SEGUNDA VUELTA ---
            CrearSegundaVuelta();

            // --- PASO C: ASIGNAR ÁRBITROS A TODOS LOS PARTIDOS GENERADOS ---
            AsignarArbitros();

            EscribirTorneo();
        }
        private void EscribirTorneo()
        {
            foreach (CLS_Partido partido in _partidos)
            {
                CLS_ManejoCSV.EscribirEnCSV("Partidos.csv", partido);
            }
            foreach (CLS_Jornada jornada in _jornadas)
            {
                CLS_ManejoCSV.EscribirEnCSV("Jornadas.csv", jornada);
            }
            //foreach (CLS_Evento evento in _eventos)
            //{
            //    CLS_ManejoCSV.EscribirEnCSV("Eventos.csv", evento);
            //}
        }
        private void CrearSegundaVuelta()
        {
            int JornadasPVuelta = _jornadas.Count;
            foreach (CLS_Jornada j in _jornadas.ToList())
            {
                CLS_Jornada jornadaSegundaVuelta = new CLS_Jornada(j._numeroJornada + JornadasPVuelta);
                jornadaSegundaVuelta._fecha = j._fecha.AddDays(7 * _jornadas.Count); // Cada jornada de la segunda vuelta usa la fecha de la primera vuelta más un número de semanas igual a la cantidad total de jornadas
                foreach (CLS_Partido p in j._partidos)
                {
                    CLS_Partido partidoSegundaVuelta = new CLS_Partido(p._equipoV, p._equipoL); // Invertimos local y visitante
                    partidoSegundaVuelta._fechayHora = p._fechayHora.AddDays(7 * _jornadas.Count); // Mismo horario pero en la fecha de la segunda vuelta
                    partidoSegundaVuelta._estadio = partidoSegundaVuelta._equipoL._estadio; // El partido se juega en el estadio del nuevo equipo local
                    partidoSegundaVuelta._IDPartido = jornadaSegundaVuelta._numeroJornada * 1000 + _idP;
                    _idP++;
                    _partidos.Add(partidoSegundaVuelta);
                    jornadaSegundaVuelta._partidos.Add(partidoSegundaVuelta);
                }
                _jornadas.Add(jornadaSegundaVuelta);
            }
        }

        private void AsignarArbitros()
        {
            foreach (CLS_Jornada j in _jornadas)
            {
                List<CLS_Arbitro> arbitrosDisponibles = new List<CLS_Arbitro>(_arbitros); // Creamos una copia de la lista de árbitros para asignar sin modificar la original
                foreach (CLS_Partido p in j._partidos)
                {
                    if (_arbitros.Count > 0)
                    {
                        p._arbitro = arbitrosDisponibles[0]; // Asignamos el primer árbitro disponible
                        p._matArbitro = arbitrosDisponibles[0]._Matricula;
                        arbitrosDisponibles.RemoveAt(0); // Lo removemos de la lista para no asignarlo a otro partido
                    }
                }
            }
        }
    }
}
