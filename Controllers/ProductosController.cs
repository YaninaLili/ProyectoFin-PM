using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFin_PM.Models;

namespace ProyectoFin_PM.Controllers
{
   
    public class ProductosController : Controller
    {
        private VidaSaludableContext _context;

        public ProductosController(VidaSaludableContext c) 
        {
            _context = c;
        }

        public IActionResult Index()
        {
            var lista = _context.Productos.ToList();
            return View(lista);
        }
        [Authorize(Roles="Administrador")]
        public IActionResult Registro() 
        {
            return View();
        }
         

        [HttpPost]
        public IActionResult Registro(Producto p)
        {
            if(ModelState.IsValid)
            {
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }    
    }
}