using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.Entities
{
    class Jugador
    {
        public int Jugador_Id { set; get; }
        public string Identificacion { set; get; }
        public byte[] FotoCedula { set; get; }
        public string Jugador_Nombre { set; get; }
        public string Nacionalidad { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public string Telefono { set; get; }
        public string CorreoElectronico { set; get; }
        public string Direccion { set; get; }
        public int CodigoEquipo { set; get; }
        public Sexo CodigoSexo { set; get; }
        public bool Estado { set; get; }

    }
}
