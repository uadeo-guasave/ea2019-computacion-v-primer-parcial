using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _05_Escuela.NetCore.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        
        [Required, MaxLength(100)]
        public string Nombre { get; set; }
        
        [Required]
        public Plan Plan { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }

    public enum Plan
    {
        Trimestral,
        Semestral
    }
}