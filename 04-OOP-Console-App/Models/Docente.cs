using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _04_OOP_Console_App.Models
{
    public class Docente
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        public string Rfc { get; set; }

        // relaciones usadas por EFCore
        public List<Calificacion> Calificaciones { get; set; }
    }
}