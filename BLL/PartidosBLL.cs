using AppJuegoOlimpico.DAL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.BLL
{
    class PartidosBLL
    {
        public void Save(Partidos partidos)
        {
            // business rule

            PartidosDAL dal = new PartidosDAL();
            if (dal.ReadById(partidos.Partido_id) == null)
                dal.Create(partidos);
            else
                dal.Update(partidos);
        }

        public List<Partidos> GetAll()
        {
            PartidosDAL dal = new PartidosDAL();
            return dal.ReadAll().OrderByDescending(x => x.Set_Number).ToList();
        }

        public void Delete(Partidos partidos)
        {
            PartidosDAL dal = new PartidosDAL();
            dal.Delete(partidos);
        }
    }
}
