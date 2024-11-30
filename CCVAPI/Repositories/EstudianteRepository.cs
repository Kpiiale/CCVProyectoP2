using CCVAPI.Data;
using CCVAPI.Interfaces;
using CCVAPI.Models;

namespace CCVAPI.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        private readonly DataContext _context;
        public EstudianteRepository(DataContext context)
        {
            _context = context;
        }
        //public ICollection<Estudiante> GetEstudiantes()
        //{
        //    return _context.Estudiantes.OrderBy(c => c.Id).ToList();
        //}

        ICollection<Estudiante> IEstudiante.GetEstudiantes()
        {
            return _context.Estudiantes.OrderBy(c => c.Id).ToList();
        }
    }

}
