using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOOreal
{
    public class EXC_CantArb : System.Exception
    {
        int _cantidadArbitros;
        int _cantidadParxJornada;
        public EXC_CantArb(int cantArbitros, int cantParxJornada)
        {
            _cantidadArbitros = cantArbitros;
            _cantidadParxJornada = cantParxJornada;
        }
        public override string Message => $"No hay suficientes árbitros para cubrir todos los partidos. Se necesitan al menos {_cantidadParxJornada} árbitros, pero solo hay {_cantidadArbitros}.";
    }
}
