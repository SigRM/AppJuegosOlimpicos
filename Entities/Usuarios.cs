using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.Entities
{
    class Usuarios
    {
        public int Id { get; set; }
        public string Usuario { set; get; }
        public string Contraseña { set; get; }
        public string NombreCompleto { set; get; }
        public byte[] FotoUsuario { set; get; }
        public Roles CodigoRoles { set; get; }

    }
}
