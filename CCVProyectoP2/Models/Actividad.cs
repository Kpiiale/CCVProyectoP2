using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCVProyectoP2.Models
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaEntrega { get; set; }
        public ICollection<ClaseActividad> ClaseActividades { get; set; }
        public ICollection<ActividadEstudiante> ActividadEstudiantes { get; set; }
        public ICollection<ActividadProfesor> ActividadProfesores { get; set; }
    }
}
