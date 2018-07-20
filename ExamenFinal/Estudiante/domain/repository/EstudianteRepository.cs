using ExamenFinal.Common.Insfraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Estudiante.domain.repository
{
    using ExamenFinal.Estudiante.domain.entity;

    public class EstudianteRepository : BaseRepository<Estudiante>, IEstudianteRepository
    {
        public List<Estudiante> getEstudianteByNivelEstudio(int idNivelEstudio)
        {
            var estudiantes = new List<Estudiante>();

            estudiantes.Add(new Estudiante() { Nombre = "Nom1", Apellido = "Ape1", Id = 1, IdTipoNivelEstudio = 1 });
            estudiantes.Add(new Estudiante() { Nombre = "Nom2", Apellido = "Ape2", Id = 1, IdTipoNivelEstudio = 2 });
            estudiantes.Add(new Estudiante() { Nombre = "Nom3", Apellido = "Ape3", Id = 1, IdTipoNivelEstudio = 3 });
            estudiantes.Add(new Estudiante() { Nombre = "Nom4", Apellido = "Ape4", Id = 1, IdTipoNivelEstudio = 1 });
            estudiantes.Add(new Estudiante() { Nombre = "Nom5", Apellido = "Ape5", Id = 1, IdTipoNivelEstudio = 2 });
            estudiantes.Add(new Estudiante() { Nombre = "Nom6", Apellido = "Ape6", Id = 1, IdTipoNivelEstudio = 3 });
            estudiantes.Add(new Estudiante() { Nombre = "Nom7", Apellido = "Ape7", Id = 1, IdTipoNivelEstudio = 1 });
            estudiantes.Add(new Estudiante() { Nombre = "Nom8", Apellido = "Ape8", Id = 1, IdTipoNivelEstudio = 2 });

            var result = estudiantes.Where(x => x.IdTipoNivelEstudio == idNivelEstudio || idNivelEstudio == 0).ToList();

            return result;
        }

        public decimal getMontoByTipoEstudios(int idNivelEstudio)
        {
            decimal monto = 0;
            var nivelEstudio = new List<NivelEstudio>();

            nivelEstudio.Add(new NivelEstudio() { Id = 1, Monto = 50, Nombre = "Pregrado" });
            nivelEstudio.Add(new NivelEstudio() { Id = 2, Monto = 100, Nombre = "Maestria" });
            nivelEstudio.Add(new NivelEstudio() { Id = 3, Monto = 150, Nombre = "Doctorado" });

            var find = nivelEstudio.Where(x => x.Id == idNivelEstudio).FirstOrDefault();

            if (find != null)
            {
                monto = find.Monto;
            }

            return monto;
        }

        public List<NivelEstudio> getNivelEstudio()
        {
            var nivelEstudio = new List<NivelEstudio>();

            nivelEstudio.Add(new NivelEstudio() { Id = 1, Monto = 50, Nombre = "Pregrado" });
            nivelEstudio.Add(new NivelEstudio() { Id = 2, Monto = 100, Nombre = "Maestria" });
            nivelEstudio.Add(new NivelEstudio() { Id = 3, Monto = 150, Nombre = "Doctorado" });
            var result = nivelEstudio;
            return result;
        }

    }
}
