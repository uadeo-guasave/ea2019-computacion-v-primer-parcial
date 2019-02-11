using System;
using System.ComponentModel.DataAnnotations;

namespace _04_OOP_Console_App.Models
{
    public class Calificacion
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int AlumnoId { get; set; }
        [Required]
        public int DocenteId { get; set; }
        [Required]
        public int MateriaId { get; set; }
        [Required]
        public int Nota { get; set; }
        [Required]
        public Periodo Periodo { get; set; }
        
        // es utilizado por EFCore para crear las relaciones
        public Alumno Alumno { get; set; }
        public Docente Docente { get; set; }
        public Materia Materia { get; set; }
    }

    public enum Periodo
    {
        Parcial1, Parcial2, Parcial3, Ordinario, Extraordinario, Especial
    }
}