using System.Collections.Generic;

namespace _04_OOP_Console_App.Models
{
    public class Docente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public List<Calificacion> Calificaciones { get; set; }
    }
}