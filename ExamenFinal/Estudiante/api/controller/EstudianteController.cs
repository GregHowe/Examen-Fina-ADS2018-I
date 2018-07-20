using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenFinal.Estudiante.application;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFinal.Estudiante.api.controller
{
    [Route("api/Estudiante")]
    public class EstudianteController : Controller
    {
        IEstudianteApplicationService _estudianteApplicationService;

        public EstudianteController(IEstudianteApplicationService estudianteApplicationService)
        {
            _estudianteApplicationService = estudianteApplicationService;
        }

        [HttpGet("{idNivelEstudio}")]
        public IActionResult GetEstudiantePorNivel(int idNivelEstudio)
        {
            try
            {
                return Ok(_estudianteApplicationService.GetEstudiantePorNivel(idNivelEstudio));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{idNivelEstudio}")]
        public IActionResult getMontoByTipoEstudios(int idNivelEstudio)
        {
            try
            {
                return Ok(_estudianteApplicationService.getMontoByTipoEstudios(idNivelEstudio));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult getNivelEstudio()
        {
            try
            {
                return Ok(_estudianteApplicationService.getNivelEstudio());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}