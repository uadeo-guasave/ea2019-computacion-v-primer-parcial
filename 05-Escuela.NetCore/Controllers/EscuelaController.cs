using Microsoft.AspNetCore.Mvc;

namespace _05_Escuela.NetCore.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}