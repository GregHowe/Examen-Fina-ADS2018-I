
namespace ExamenFinal.Estudiante.application
{
    using ExamenFinal.Common.Insfraestructure.Repository;
    using System;
    using System.Collections.Generic;
    using domain.entity;

    public class EstudianteApplicationService : IEstudianteApplicationService
    {
        private readonly IUnitOfWork _iUnitOfWork;

        public EstudianteApplicationService(IUnitOfWork iUnitOfWork)
        {
            _iUnitOfWork = iUnitOfWork;
        }

        public List<Estudiante> GetEstudiantePorNivel(int idNivelEstudio)
        {
            var result  = _iUnitOfWork.Estudiante.getEstudianteByNivelEstudio(idNivelEstudio);
            return result;
        }

        public decimal getMontoByTipoEstudios(int idNivelEstudio)
        {
            var result = _iUnitOfWork.Estudiante.getMontoByTipoEstudios(idNivelEstudio);
            return result;
        }

        public List<NivelEstudio> getNivelEstudio()
        {
            var result = _iUnitOfWork.Estudiante.getNivelEstudio();
            return result;
        }


    }
}
