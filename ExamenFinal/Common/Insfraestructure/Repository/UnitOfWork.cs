using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.Insfraestructure.Repository
{
    using ExamenFinal.Estudiante.domain.repository;

    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            Estudiante = new EstudianteRepository();
        }

        public IEstudianteRepository Estudiante { get; private set; }

        public int Complete()
        {
            return 1;
        }

        public void Dispose()
        {
       
        }
    }
}
