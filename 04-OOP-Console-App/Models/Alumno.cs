using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _04_OOP_Console_App.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string Matricula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public Carrera Carrera { get; set; }
        public Genero Genero { get; set; }
        public List<Calificacion> Calificiones { get; set; }


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