using System;

namespace _04_OOP_Console_App.Models
{
    public class Calificacion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Alumno Alumno { get; set; }
        public Docente Docente { get; set; }
        public Materia Materia { get; set; }
        public int Nota { get; set; }
    }
}