﻿using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPI.Models
{
    public class ClaseEstudiante
    {
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        public int ClaseId { get; set; }
        public Clase Clase { get; set; }
        [Required]
        public GradoEnum Grado { get; set; }
    }
}
