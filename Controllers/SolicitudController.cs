using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Programacion_PC3.Models;
using Programacion_PC3.Data;

namespace Programacion_PC3.Controllers
{
    public class SolicitudController : Controller
    {
        private readonly ILogger<SolicitudController> _logger;
        private readonly ApplicationDbContext _context;

        public SolicitudController(ILogger<SolicitudController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar(Producto producto){
            producto.addDate= DateTime.Today;
            if(ModelState.IsValid)
            {
                _context.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View("Index");
            }
            
        }

    }
}
