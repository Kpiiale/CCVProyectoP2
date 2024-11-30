﻿using CCVAPI.Interfaces;
using CCVAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCVAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : Controller
    {
        private readonly IEstudiante _estudiante;
        public EstudiantesController(IEstudiante estudiante)
        {
            _estudiante = estudiante;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Estudiante>))]
        public IActionResult GetEstudiantes()
        {
            var estudiantes = _estudiante.GetEstudiantes();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(estudiantes);

        }
    }

}
