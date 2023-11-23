using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.Entities
{
    class Partidos
    {
        public int Partido_id { set; get; }
        public int Equipo1_id { set; get; }
        public int Equipo2_id { set; get; }
        public DateTime fecha { set; get; }
        public bool Estado { set; get; }
        public int Set_Number { set; get; }
        public int Equipo1_Puntos { set; get; }
        public int Equipo2_Puntos { set; get; }

    }
}
