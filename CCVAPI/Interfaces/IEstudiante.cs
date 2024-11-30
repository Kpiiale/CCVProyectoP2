using CCVAPI.Models;

namespace CCVAPI.Interfaces
{
    public interface IEstudiante
    {
        ICollection<Estudiante> GetEstudiantes();
    }
}
