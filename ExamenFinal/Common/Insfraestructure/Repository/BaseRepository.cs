using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.Insfraestructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public List<T> GetAll()
        {
            var result = new List<T>();
            return result; 
        }
    }
}
