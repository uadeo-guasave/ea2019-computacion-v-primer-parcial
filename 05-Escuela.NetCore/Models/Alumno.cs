using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _05_Escuela.NetCore.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string Matricula { get; set; }
        [Required, MaxLength(50)]
        public string Nombre { get; set; }
        [Required, MaxLength(50)]
        public string Apellidos { get; set; }
        [Required, MaxLength(200)]
        public string CorreoElectronico { get; set; }
        [Required]
        public Genero Genero { get; set; }
        [Required]
        public int CarreraId { get; set; }
        
        
        public Carrera Carrera { get; set; }
        // public List<AlumnoCalificaciones> AlumnoCalificaciones { get; set; }


        [NotMapped]
        public string NombreCompleto
        {
            get { return Nombre + " " + Apellidos; }
        }
    }
    public enum Genero
    {
        Hombre,
        Mujer
    }
}