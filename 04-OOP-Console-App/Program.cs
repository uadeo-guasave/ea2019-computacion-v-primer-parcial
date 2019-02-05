using System;
using _04_OOP_Console_App.Models;

namespace _04_OOP_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var alumno = new Alumno();
            // alumno.Id = 1;
            alumno.Nombre = "Bidkar";
            alumno.Apellidos = "Aragon";
            Console.WriteLine("Id: " + alumno.Id + ", Nombre: " + alumno.NombreCompleto);

            var otro = Alumno.NuevoAlumno();
            otro.Nombre = "Juan";
            otro.Apellidos = "Gomez";
            Console.WriteLine("Id: " + otro.Id + ", Nombre: " + otro.NombreCompleto);

            var ultimo = new Alumno()
            {
                Nombre = "Ultimo",
                Apellidos = "Alumno",
                Matricula = "9730035",
                CorreoElectronico = "baragon@udo.mx"
            };
            Console.WriteLine("Id: " + ultimo.Id + ", Nombre: " + ultimo.NombreCompleto);


        }
    }
}
