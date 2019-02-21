using System;
using System.Collections.Generic;
using _04_OOP_Console_App.Models;

namespace _04_OOP_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // CrearCarreras();
            // ImprimirCarreras();
            var carrera = BuscarCarreraPorId(3);
            // carrera.Plan = Plan.Trimestral;
            // TODO: ActualizarCarrera(int id);
            // ActualizarCarrera(carrera);
            // TODO: EliminarCarrera(int id);
            EliminarCarrera(carrera);
        }

        private static void EliminarCarrera(Carrera carrera)
        {
            using (var db = new UdoDbContext())
            {
                db.Carreras.Remove(carrera);
                db.SaveChanges();
                ImprimirCarreras();
            }
        }

        private static void ActualizarCarrera(Carrera carrera)
        {
            using (var db = new UdoDbContext())
            {
                db.Carreras.Update(carrera);
                db.SaveChanges();
                ImprimirCarreras();
            }
        }

        private static Carrera BuscarCarreraPorId(int carreraId)
        {
            using (var db = new UdoDbContext())
            {
                var carrera = db.Carreras.Find(carreraId);
                return carrera;
            }
        }

        private static void ImprimirCarreras()
        {
            using (var db = new UdoDbContext())
            {
                var carreras = db.Carreras;
                foreach (var c in carreras)
                {
                    Console.WriteLine($"Nombre: {c.Nombre}, Plan: {c.Plan}");
                }
            }
        }

        private static void CrearCarreras()
        {
            using (var db = new UdoDbContext())
            {
                db.Database.EnsureCreated();

                var carreras = new List<Carrera>
                {
                    new Carrera()
                    {
                        Nombre = "Contabilidad",
                        Plan = Plan.Trimestral
                    },
                    new Carrera()
                    {
                        Nombre = "Administración y finanzas",
                        Plan = Plan.Semestral
                    },
                    new Carrera()
                    {
                        Nombre = "Ingeniería civil",
                        Plan = Plan.Trimestral
                    }
                };
                // var carrera1 = new Carrera()
                // {
                //     Nombre = "Contabilidad",
                //     Plan = Plan.Trimestral
                // };
                // var carrera2 = new Carrera()
                // {
                //     Nombre = "Administración y finanzas",
                //     Plan = Plan.Semestral
                // };
                // var carrera3 = new Carrera()
                // {
                //     Nombre = "Ingeniería civil",
                //     Plan = Plan.Trimestral
                // };

                // db.Add(carrera1);
                // db.Add(carrera2);
                // db.Add(carrera3);

                db.AddRange(carreras);

                db.SaveChanges();
            }
        }
    }
}
