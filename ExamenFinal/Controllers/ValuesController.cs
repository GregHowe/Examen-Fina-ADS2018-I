using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //public class NivelEstudio
        //{
        //    public int Id { get; set; }
        //    public string Nivel { get; set; }
        //    public decimal monto { get; set; }
        //}

        //public class Estudiante
        //{
        //    public int Id { get; set; }
        //    public string Nombre { get; set; }
        //    public decimal Apellido { get; set; }
        //    //public decimal IdTipoNivelEstudio { get; set; }
        //    public NivelEstudio nivelEstudio { get; set; }
        //}


    }
}
