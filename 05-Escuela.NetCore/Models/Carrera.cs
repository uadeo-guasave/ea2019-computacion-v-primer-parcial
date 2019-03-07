using System.ComponentModel.DataAnnotations;

namespace _05_Escuela.NetCore.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Plan Plan { get; set; }
    }

    public enum Plan
    {
        Trimestral,
        Semestral
    }
}