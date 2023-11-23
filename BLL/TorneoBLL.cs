using AppJuegoOlimpico.DAL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.BLL
{
    class TorneoBLL
    {
        public void Save(Torneo torneo)
        {
            // business rule
            if (torneo.Torneo_Nombre.Length < 2)
                throw new ApplicationException("El nombre debe tener más de 2 letras");

            TorneoDAL dal = new TorneoDAL();
            if (dal.ReadById(torneo.Torneo_Id) == null)
                dal.Create(torneo);
            else
                dal.Update(torneo);
        }

        public List<Torneo> GetAll()
        {
            TorneoDAL dal = new TorneoDAL();
            return dal.ReadAll().OrderByDescending(x => x.Torneo_Nombre).ToList();
        }

        public void Delete(Torneo torneo)
        {
            TorneoDAL dal = new TorneoDAL();
            dal.Delete(torneo);
        }
    }
}
