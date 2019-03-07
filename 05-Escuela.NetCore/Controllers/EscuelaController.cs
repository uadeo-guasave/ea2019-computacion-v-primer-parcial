using System.Collections.Generic;
using _05_Escuela.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Escuela.NetCore.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuelas = new List<Escuela>
            {
                new Escuela {Id=1,Nombre="UAdeO",Ubicación="Guasave, Sinaloa",Director="Fridzia Izaguirre Diaz de León"},
                new Escuela {Id=2,Nombre="UAS",Ubicación="Culiacan, Sinaloa",Director="Dire de culichi"},
                new Escuela {Id=3,Nombre="UNIVAFU",Ubicación="Los Mochis, Sinaloa",Director="El de mochis"}
            };
            return View(escuelas);
        }

        // CRUD: Create Read Update Delete
        // HTTP: POST=Create Get=Read Put=Update Delete=Delete
        [HttpGet("/Escuela/Detalle/{id}")]
        public IActionResult Detalle(int id)
        {
            Escuela escuela;
            if (id == 1)
            {
                escuela = new Escuela {Id=1,Nombre="UAdeO",Ubicación="Guasave, Sinaloa",Director="Fridzia Izaguirre Diaz de León"};
            }
            else
            {
                escuela = null;
            }
            
            return View(escuela);
        }
    }
}