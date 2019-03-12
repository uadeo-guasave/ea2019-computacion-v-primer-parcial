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
    }
}