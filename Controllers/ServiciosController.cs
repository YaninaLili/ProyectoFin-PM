using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFin_PM.Models;

namespace ProyectoFin_PM.Controllers
{
    public class ServiciosController : Controller
    {
        private VidaSaludableContext _context;

        public ServiciosController(VidaSaludableContext c)
        {
            _context = c;
        }

        public IActionResult Index()
        {
            var lista = _context.Servicios.ToList();
            return View(lista);
        }
        [Authorize(Roles="Administrador")]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Servicio s)
        {
            if (ModelState.IsValid)
            {
                _context.Add(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);
        }
    }
}