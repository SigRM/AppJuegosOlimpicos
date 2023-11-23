using AppJuegoOlimpico.DAL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.BLL
{
    class SexoBLL
    {
        public void Save(Sexo sexo)
        {
            // business rule
            if (sexo.Nombre.Length < 2)
                throw new ApplicationException("El nombre debe tener más de 2 letras");

            SexoDAL dal = new SexoDAL();
            if (dal.ReadById(sexo.Codigo) == null)
                dal.Create(sexo);
            else
                dal.Update(sexo);
        }

        public List<Sexo> GetAll()
        {
            SexoDAL dal = new SexoDAL();
            return dal.ReadAll().OrderByDescending(x => x.Nombre).ToList();
        }
    }
}
