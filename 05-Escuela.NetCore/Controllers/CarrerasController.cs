using System.Linq;
using _05_Escuela.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Escuela.NetCore.Controllers
{
    public class CarrerasController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new SqliteDbContext())
            {
                var carreras = db.Carreras.ToList();
                
                return View(carreras);
            }
        }

        public IActionResult Nueva()
        {
            return View();
        }

        [HttpGet("/Carreras/Editar/{carreraId}")]
        public IActionResult Editar(int carreraId)
        {
            using (var db = new SqliteDbContext())
            {
                var carrera = db.Carreras.Find(carreraId);
                return View(carrera);
            }
        }

        [HttpGet("/Carreras/Eliminar/{carreraId}")]
        public IActionResult Eliminar(int carreraId)
        {
            using (var db = new SqliteDbContext())
            {
                var carrera = db.Carreras.Find(carreraId);
                db.Remove(carrera);
                db.SaveChanges();

                return View("Index", carrera.Nombre);
            }
        }
    }
}