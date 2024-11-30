﻿using WebApplicationAPI.Models;

namespace WebApplicationAPI.Interfaces
{
    public interface IAdministrador
    {
        ICollection<Profesor> GetProfesores();
        ICollection<Estudiante> GetEstudiantes();
        ICollection<Clase> GetClases();
        ICollection<Actividad> GetActividades();
    }
}
