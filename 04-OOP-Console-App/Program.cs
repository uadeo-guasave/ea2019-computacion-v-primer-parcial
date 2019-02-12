using System;
using _04_OOP_Console_App.Models;

namespace _04_OOP_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UdoDbContext())
            {
                db.Database.EnsureCreated();

                var carrera = new Carrera
                {
                    Id = 1,
                    Nombre = "Sistemas Computacionales",
                    Plan = Plan.Trimestral
                };

                var alumno = new Alumno
                {
                    Nombre = "Bidkar",
                    Apellidos = "Aragon",
                    CorreoElectronico = "bidkar.aragon@udo.mx",
                    Matricula = "9730035",
                    Genero = Genero.Hombre,
                    CarreraId = 1
                };

                db.Add(carrera);

                db.SaveChanges();
                Console.WriteLine("Datos guardados");
                Console.ReadLine();
            }
        }
    }
}
