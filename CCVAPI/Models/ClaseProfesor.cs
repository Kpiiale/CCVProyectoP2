using System.ComponentModel.DataAnnotations;

namespace CCVAPI.Models
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
