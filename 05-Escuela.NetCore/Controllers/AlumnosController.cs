using System.Linq;
using _05_Escuela.NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _05_Escuela.NetCore
{
    public class AlumnosController : Controller
    {
      public IActionResult Index()
      {
        using (var db = new SqliteDbContext())
        {
          var alumnos = db.Alumnos.Include(c => c.Carrera).ToList();
          return View(alumnos);
        }
      }

      [HttpGet]
      public IActionResult Nuevo()
      {
        return View();
      }

      [HttpPost]
      public IActionResult Nuevo(Alumno alumno)
      {
        if (alumno != null && ModelState.IsValid)
        {
            using (var db = new SqliteDbContext())
            {
                db.Add(alumno);
                db.SaveChanges();
            }
        }
        return View("Index");
      }

      [HttpGet]
      public IActionResult Editar(int? id)
      {
        if (id != null)
        {
            using (var db = new SqliteDbContext())
            {
                var alumno = db.Alumnos.Find(id);
                return View(alumno);
            }
        }
        return View("Index");
      }
      
      [HttpPost]
      public IActionResult Editar(int id, Alumno alumnoCambios)
      {
        using (var db = new SqliteDbContext())
        {
            var alumno = db.Alumnos.Find(id);
            if(alumno != null && ModelState.IsValid)
            {
              alumno.Matricula = alumnoCambios.Matricula;
              alumno.Nombre = alumnoCambios.Nombre;
              alumno.Apellidos = alumnoCambios.Apellidos;
              alumno.CorreoElectronico = alumnoCambios.CorreoElectronico;
              alumno.Genero = alumnoCambios.Genero;
              alumno.CarreraId = alumnoCambios.CarreraId;
              db.SaveChanges();
            }
        }
        return View("Index");
      }
      
      [HttpGet]
      public IActionResult Eliminar(int id)
      {
        using (var db = new SqliteDbContext())
            {
                var alumno = db.Alumnos.Find(id);
                if (alumno != null)
                {
                    db.Remove(alumno);
                    db.SaveChanges();
                }
            }
        return View("Index");
      }
    }
}