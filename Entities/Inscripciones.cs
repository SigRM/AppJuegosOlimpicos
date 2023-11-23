using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.Entities
{
    class Inscripciones
    {
        public string ModalidadPago { set; get; }
        public double MontoPagoCRC { set; get; }
        public double MontoPagoUSD { set; get; }
        public DateTime FechaInscripcion { set; get; }
        public double TipoCambio { set; get; }
        public bool Estado { set; get; }
        public int Inscripcion_Id { set; get; }
        public Torneo Torneo_Id { set; get; }
        public Jugador Jugador_Id { set; get; }
        public string Correo { set; get; }


    }
}
