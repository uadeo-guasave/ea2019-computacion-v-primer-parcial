using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _04_OOP_Console_App.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Plan Plan { get; set; }

        // EFCore relationships
        public List<Materia> Materias { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }

    public enum Plan
    {
        Trimestral,
        Semestral
    }
}