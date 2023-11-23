using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.Entities
{
    class Torneo
    {
        public int Torneo_Id { set; get; }
        public string Torneo_Nombre { set; get; }
        public string Promotora { set; get; }
        public DateTime FechaInicio { set; get; }
        public DateTime FechaFinal { set; get; }
        public double CostoCRC { set; get; }
        public double CostoUSD { set; get; }
        public bool Estado { set; get; }
        public string Correo { set; get; }

    }
}
