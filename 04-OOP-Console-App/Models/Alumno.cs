using System;

namespace _04_OOP_Console_App.Models
{
    public class Alumno
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Matricula { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreCompleto
        {
            get { return Nombre + " " + Apellidos; }
        }
        
        public Alumno()
        {
            Id = Guid.NewGuid().ToString();
        }

        public static Alumno NuevoAlumno() => new Alumno();
    }
}