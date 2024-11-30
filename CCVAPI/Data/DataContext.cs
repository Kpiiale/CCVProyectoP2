﻿using CCVAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CCVAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
        base(options)
        {

        }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<ActividadEstudiante> ActividadEstudiantes { get; set; }
        public DbSet<ActividadProfesor> ActividadProfesores { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<ClaseActividad> ClaseActividades { get; set; }
        public DbSet<ClaseEstudiante> ClaseEstudiantes { get; set; }
        public DbSet<ClaseProfesor> ClaseProfesores { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Administrador> Administrador { get; set; } = default!;
        public DbSet<Materia> Materias { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClaseEstudiante>()
                .HasKey(c => new { c.EstudianteId, c.ClaseId });
            modelBuilder.Entity<ClaseEstudiante>()
                .HasOne(c => c.Estudiante)
                .WithMany(c => c.ClaseEstudiantes)
                .HasForeignKey(c => c.EstudianteId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ClaseEstudiante>()
                .HasOne(c => c.Clase)
                .WithMany(c => c.ClaseEstudiantes)
                .HasForeignKey(c => c.ClaseId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ClaseEstudiante>()
                .Property(c => c.Grado)
                .IsRequired();
            modelBuilder.Entity<ClaseProfesor>()
                .HasKey(c => new { c.ProfesorId, c.ClasePId });
            modelBuilder.Entity<ClaseProfesor>()
                .HasOne(c => c.Profesor)
                .WithMany(c => c.ClaseProfesores)
                .HasForeignKey(c => c.ProfesorId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ClaseProfesor>()
                .HasOne(c => c.ClaseP)
                .WithMany(c => c.ClaseProfesores)
                .HasForeignKey(c => c.ClasePId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ClaseProfesor>()
                .Property(c => c.Materia)
                .IsRequired();
            modelBuilder.Entity<ClaseActividad>()
                .HasKey(c => new { c.ActividadId, c.ClaseId });
            modelBuilder.Entity<ClaseActividad>()
                .HasOne(c => c.Actividad)
                .WithMany(c => c.ClaseActividades)
                .HasForeignKey(c => c.ActividadId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ClaseActividad>()
                .HasOne(c => c.Clase)
                .WithMany(c => c.ClaseActividades)
                .HasForeignKey(c => c.ClaseId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ActividadEstudiante>()
                .HasKey(c => new { c.ActividadId, c.EstudianteId });
            modelBuilder.Entity<ActividadEstudiante>()
                .HasOne(c => c.Estudiante)
                .WithMany(c => c.ActividadEstudiantes)
                .HasForeignKey(c => c.EstudianteId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ActividadEstudiante>()
                .HasOne(c => c.Actividad)
                .WithMany(c => c.ActividadEstudiantes)
                .HasForeignKey(c => c.ActividadId);
            modelBuilder.Entity<ActividadProfesor>()
                .HasKey(c => new { c.ActividadId, c.ProfesorId });
            modelBuilder.Entity<ActividadProfesor>()
                .HasOne(c => c.Profesor)
                .WithMany(c => c.ActividadProfesores)
                .HasForeignKey(c => c.ProfesorId);
            modelBuilder.Entity<ActividadProfesor>()
                .HasOne(c => c.Actividad)
                .WithMany(c => c.ActividadProfesores)
                .HasForeignKey(c => c.ActividadId);
            modelBuilder.Entity<Administrador>().HasData(new Administrador
            {
                Id = 1,
                Cedula = "1234567890",
                Nombre = "Roberto",
                NombreUsuario = "admin",
                Contrasenia = "admin",
                Edad = 30,
                Rol = RolEnum.Administrador,
            });
        }
    }
}
