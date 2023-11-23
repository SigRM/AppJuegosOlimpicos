using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.Entities
{
    class LogIn
    {
        public string Identificacion { set; get; }
        public string contrasena { set; get; }
        public string rol { set; get; }

        public static LogIn _Usuario;
        private LogIn() { }

        public static LogIn GetInstance()
        {
            if (_Usuario == null)
                _Usuario = new LogIn();
            return _Usuario;
        }
    }
}
