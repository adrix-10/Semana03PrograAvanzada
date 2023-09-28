using Microsoft.AspNetCore.Mvc;
using Semana03.Models;

namespace Semana03.Controllers
{
    public class EstudianteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearEstudiante(Estudiante estudiante) 
        {
            ViewBag.Titulo = "Información del Estudiante";

            return View("Detalle", estudiante);
        }
    }
}
