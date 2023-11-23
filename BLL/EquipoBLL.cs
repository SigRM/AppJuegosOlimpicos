using AppJuegoOlimpico.DAL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.BLL
{
    class EquipoBLL
    {
        public void Save(Equipo equipo)
        {
            // business rule
           if (equipo.Equipo_Nombre.Length < 2)
                throw new ApplicationException("El nombre debe tener más de 2 letras");

            EquipoDAL dal = new EquipoDAL();
            if (dal.ReadById(equipo.Equipo_Id) == null)
                dal.Create(equipo);
            else
                dal.Update(equipo);
        }

        public List<Equipo> GetAll()
        {
            EquipoDAL dal = new EquipoDAL();
            return dal.ReadAll().OrderByDescending(x => x.Equipo_Nombre).ToList();
        }

        public void Delete(Equipo equipo)
        {
            EquipoDAL dal = new EquipoDAL();
            dal.Delete(equipo);
        }
    }
}
