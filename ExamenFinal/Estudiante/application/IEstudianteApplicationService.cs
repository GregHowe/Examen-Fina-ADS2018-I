
namespace ExamenFinal.Estudiante.application
{
    using ExamenFinal.Estudiante.domain.entity;
    using System.Collections.Generic;

    public interface IEstudianteApplicationService
    {
        
        List<Estudiante> GetEstudiantePorNivel(int idNivelEstudio);
        decimal getMontoByTipoEstudios(int idNivelEstudio);
        List<NivelEstudio> getNivelEstudio();

    }
}
