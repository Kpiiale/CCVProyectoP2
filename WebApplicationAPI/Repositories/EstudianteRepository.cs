using WebApplicationAPI.Data;
using WebApplicationAPI.Interfaces;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        private readonly DataContext _context;
        public EstudianteRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Estudiante> GetEstudiantes()
        {
            return _context.Estudiantes.OrderBy(c=>c.Id).ToList();
        }
    }
}
