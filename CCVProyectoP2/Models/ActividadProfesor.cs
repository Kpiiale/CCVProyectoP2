using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCVProyectoP2.Models
{
    public class ActividadProfesor
    {
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        public int ActividadId { get; set; }
        public Actividad Actividad { get; set; }
    }
}
