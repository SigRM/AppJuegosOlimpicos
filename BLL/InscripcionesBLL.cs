using AppJuegoOlimpico.DAL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.BLL
{
    class InscripcionesBLL
    {
        public void Save(Inscripciones inscripciones)
        {
            // business rule
            if (inscripciones.Correo.Length < 2)
                throw new ApplicationException("El nombre debe tener más de 2 letras");

            InscripcionesDAL dal = new InscripcionesDAL();
            if (dal.ReadById(inscripciones.Inscripcion_Id) == null)
                dal.Create(inscripciones);
            else
                dal.Update(inscripciones);
        }

        public List<Inscripciones> GetAll()
        {
            InscripcionesDAL dal = new InscripcionesDAL();
            return dal.ReadAll().OrderByDescending(x => x.Inscripcion_Id).ToList();
        }

        public void Delete(Inscripciones category)
        {
            InscripcionesDAL dal = new InscripcionesDAL();
            dal.Delete(category);
        }
    }
}
