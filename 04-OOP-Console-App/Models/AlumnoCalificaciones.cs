namespace _04_OOP_Console_App.Models
{
    public class AlumnoCalificaciones
    {
        public int AlumnoId { get; set; }
        public int CalificacionId { get; set; }

        // EFCore rels
        public Alumno Alumno { get; set; }
        public Calificacion Calificacion { get; set; }
    }
}