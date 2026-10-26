using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class CLS_Partido : IUsoCSV
    {
        public CLS_Equipo _equipoL { get; set; }
        public int _idEqL { get; set; }
        public int _golesEqL { get; set; }
        public CLS_Equipo _equipoV { get; set; }
        public int _idEqV { get; set; }
        public int _golesEqV { get; set; }
        public CLS_Arbitro _arbitro { get; set; }
        public string _matArbitro { get; set; }

        public List<CLS_Evento> _eventos = new List<CLS_Evento>();
        public List<CLS_RolPartido> _roles { get; set; } = new List<CLS_RolPartido>();
        public CLS_Estadio _estadio { get; set; }
        public int _IDPartido { get; set; }
        public bool _registrado { get; set; } = false;
        public DateTime _fechayHora { get; set; }
        
        public delegate void EventoRegistradoHandler(CLS_Evento evento);
        public event EventoRegistradoHandler OnEventoRegistrado;

        public CLS_Partido(CLS_Equipo L, CLS_Equipo V, CLS_Arbitro arbitro, CLS_Estadio estadio, int n)
        {
            _equipoL = L;
            _idEqL = L._IDEquipo;
            _equipoV = V;
            _idEqV = V._IDEquipo;
            _arbitro = arbitro;
            _matArbitro = arbitro._Matricula;
            _estadio = estadio;
            _IDPartido = n;
        }
        public CLS_Partido(CLS_Equipo L, CLS_Equipo V)
        {
            _equipoL = L;
            _equipoV = V;
            _idEqL = L._IDEquipo;
            _idEqV = V._IDEquipo;
        }
        public CLS_Partido()
        {
        }
        public void AsignarObjetos()
        {
            foreach (CLS_Equipo e in CLS_ManejoCSV.LeerCSV("Equipos.csv", new CLS_Equipo()))
            {
                e.AsignarEstadio();
                if(e._IDEquipo == _idEqL)
                {
                    _equipoL = e;
                    _estadio = e._estadio;
                }
                if(e._IDEquipo == _idEqV)
                {
                    _equipoV = e;
                }
            }
            foreach (CLS_Arbitro a in CLS_ManejoCSV.LeerCSV("Arbitros.csv", new CLS_Arbitro()))
            {
                if(a._Matricula.Equals(_matArbitro))
                {
                    _arbitro = a;
                }
            }
            if(_registrado)
            {
                _eventos.Clear();
                foreach (CLS_Evento ev in CLS_ManejoCSV.LeerCSV("Eventos.csv", new CLS_Evento()))
                {
                    if (ev._idPartido == _IDPartido)
                    {
                        _eventos.Add(ev);
                    }
                }
            }
        }
        public string LineaCSV()
        {           
            return $"{_IDPartido};{_idEqL};{_golesEqL};{_idEqV};{_golesEqV};{_matArbitro};{_fechayHora.ToString("yyyy-MM-dd HH:mm:ss")};{_registrado.ToString()}";
        }

        public void CargarDesdeCSV(string[] partes)
        {
            if (partes.Length >= 8)
            {
                _IDPartido = int.Parse(partes[0].Trim());
                _idEqL = int.Parse(partes[1].Trim());
                _golesEqL = int.TryParse(partes[2].Trim(), out int golesL) ? golesL : 0;
                _idEqV = int.Parse(partes[3].Trim());
                _golesEqV = int.TryParse(partes[4].Trim(), out int golesV) ? golesV : 0;
                _matArbitro = partes[5].Trim();
                _fechayHora = DateTime.Parse(partes[6].Trim());
                _registrado = bool.Parse(partes[7].Trim());
            }
        }

        public string[] ObtenerEncabezadosCSV()
        {
            return new string[] { "ID Partido", "ID Equipo Local", "Goles Local", "ID Equipo Visitante", "Goles Visitante", "Matricula Arbitro", "Fecha y hora", "Registrado"};
        }
        public string ObtenerIDCSV() => _IDPartido.ToString();
        public void AgregarEvento(CLS_Evento evento)
        {
            _eventos.Add(evento);
            OnEventoRegistrado?.Invoke(evento);   
            if (evento._tipo == CLS_Evento.TipoEvento.Gol)
            {
                if (evento._eqAutor._IDEquipo == _equipoL._IDEquipo)
                {
                    _golesEqL++;
                }
                else
                {
                    _golesEqV++;
                }
            }
        }
        public override string ToString()
        {
            return $"{_equipoL._nombreEquipo} {_golesEqL} - {_golesEqV} {_equipoV._nombreEquipo}";
        }
    }
}
