﻿using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPI.Models
{
    public class Estudiante: Usuario
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public GradoEnum Grado { get; set; }
        public ICollection<ClaseEstudiante> ClaseEstudiantes { get; set; }
        public ICollection<ActividadEstudiante> ActividadEstudiantes { get; set; }


    }
}
