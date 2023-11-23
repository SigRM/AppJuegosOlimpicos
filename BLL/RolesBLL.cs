using AppJuegoOlimpico.DAL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.BLL
{
    class RolesBLL
    {
        public void Save(Roles roles)
        {
            // business rule
            if (roles.Nombre.Length < 2)
                throw new ApplicationException("El nombre debe tener más de 2 letras");

            RolesDAL dal = new RolesDAL();
            if (dal.ReadById(roles.Codigo) == null)
                dal.Create(roles);
            else
                dal.Update(roles);
        }

        public List<Roles> GetAll()
        {
            RolesDAL dal = new RolesDAL();
            return dal.ReadAll().OrderByDescending(x => x.Nombre).ToList();
        }

        public void Delete(Roles roles)
        {
            RolesDAL dal = new RolesDAL();
            dal.Delete(roles);
        }
    }
}
