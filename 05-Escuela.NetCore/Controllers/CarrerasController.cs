using System.Linq;
using _05_Escuela.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Escuela.NetCore.Controllers
{
    public class CarrerasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Nueva()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Nueva(Carrera carrera)
        {
            using (var db = new SqliteDbContext())
            {
                if (ModelState.IsValid)
                {
                    db.Add(carrera);
                    db.SaveChanges();
                }
                
                return View("Index");
            }
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            using (var db = new SqliteDbContext())
            {
                var carrera = db.Carreras.Find(id);
                return View(carrera);
            }
        }

        [HttpPost]
        public IActionResult Editar(int id, Carrera carreraInput)
        {
            using (var db = new SqliteDbContext())
            {
                var carrera = db.Carreras.Find(id);
                if (carrera != null && ModelState.IsValid)
                {
                    carrera.Nombre = carreraInput.Nombre;
                    carrera.Plan = carreraInput.Plan;
                    db.SaveChanges();
                }
                
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            using (var db = new SqliteDbContext())
            {
                var carrera = db.Carreras.Find(id);
                if (carrera != null)
                {
                    db.Remove(carrera);
                    db.SaveChanges();
                }

                return View("Index");
            }
        }
    }
}