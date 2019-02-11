using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _04_OOP_Console_App.Models
{
    public class Materia
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Periodo { get; set; }
        [Required]
        public int Horas { get; set; }
        [Required]
        public int Creditos { get; set; }
        [Required]
        public int CarreraId { get; set; }

        // utilizadas por EFCore
        public Carrera Carrera { get; set; }
        public List<Calificacion> Calificaciones { get; set; }
    }
}