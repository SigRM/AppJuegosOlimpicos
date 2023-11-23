using AppJuegoOlimpico.DAL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.BLL
{
    class JugadorBLL
    {
        public void Save(Jugador jugador)
        {
            JugadorDAL dal = new JugadorDAL();
            if (dal.ReadById(jugador.Jugador_Id) == null)
                dal.Create(jugador);
            else
                dal.Update(jugador);
        }
        public List<Jugador> GetJugadores()
        {
            return new DAL.JugadorDAL().ReadAll();
        }

        public void Delete(Jugador jugador)
        {
            JugadorDAL dal = new JugadorDAL();
            dal.Delete(jugador);
        }
    }
}
