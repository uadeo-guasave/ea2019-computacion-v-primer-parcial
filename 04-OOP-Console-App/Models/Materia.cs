using System.Collections.Generic;

namespace _04_OOP_Console_App.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Periodo { get; set; }
        public int Horas { get; set; }
        public int Creditos { get; set; }
        public Carrera Carrera { get; set; }
        public List<Calificacion> Calificaciones { get; set; }
    }
}