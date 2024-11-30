﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPI.Models
{
    public class Clase
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [Display(Name = "Clase")]
        public Materia Materia { get; set; }

        //public Profesor Profesor { get; set; }
        //[ForeignKey(nameof(Profesor))]
        //[Required(ErrorMessage = "Este campo es obligatorio.")]
        //[Display(Name = "Profesor")]
        //public int IdProfesor { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public Grado Grado { get; set; }
        public ICollection<ClaseEstudiante> ClaseEstudiantes { get; set; }
        public ICollection<ClaseProfesor> ClaseProfesores { get; set; }
        public ICollection<ClaseActividad> ClaseActividades { get; set; }

    }
}
