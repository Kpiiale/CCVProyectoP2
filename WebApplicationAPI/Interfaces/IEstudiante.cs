using WebApplicationAPI.Models;

namespace WebApplicationAPI.Interfaces
{
    public interface IEstudiante
    {
        ICollection<Estudiante> GetEstudiantes();
    }
}
