using AppJuegoOlimpico.DAL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.BLL
{
    class UsuariosBLL
    {
        public void Save(Usuarios usuarios)
        {
            // business rule
            if (usuarios.NombreCompleto.Length < 2)
                throw new ApplicationException("El nombre debe tener más de 2 letras");

            UsuariosDAL dal = new UsuariosDAL();
         /*   if (dal.ReadById(usuarios.CodigoRoles == null)
                dal.Create(usuarios);
            else
                dal.Update(usuarios);*/
        }

        public List<Usuarios> GetAll()
        {
            UsuariosDAL dal = new UsuariosDAL();
            return dal.ReadAll().OrderByDescending(x => x.NombreCompleto).ToList();
        }

        public void Delete(Usuarios category)
        {
            UsuariosDAL dal = new UsuariosDAL();
            dal.Delete(category);
        }
    }
}
