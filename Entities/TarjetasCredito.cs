using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.Entities
{
    class TarjetasCredito
    {
            public int id { set; get; }
            public string numero_tarjeta { set; get; }
            public string nombre_titular { set; get; }
            public DateTime fecha_vencimiento { set; get; }
            public string codigo_seguridad { set; get; }
            public string tipo_tarjeta { set; get; }
        }

    }