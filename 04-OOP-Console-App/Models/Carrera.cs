using System.Collections.Generic;

namespace _04_OOP_Console_App.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Plan Plan { get; set; }
        public List<Materia> Materias { get; set; }
    }

    public enum Plan
    {
        Trimestral,
        Semestral
    }
}