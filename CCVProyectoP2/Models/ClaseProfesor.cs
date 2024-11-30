using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCVProyectoP2.Models
{
    public class ClaseProfesor
    {
        public int ClasePId { get; set; }
        public Clase ClaseP { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        [Required]
        public MateriaEnum Materia { get; set; }
    }
}
