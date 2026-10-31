using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UsandoCRUD_Validaciones.Datos;
using UsandoCRUD_Validaciones.Models;

namespace UsandoCRUD_Validaciones.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoriaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Categoria> lista = _db.Categoria;
            return View(lista);
        }
    }
}
