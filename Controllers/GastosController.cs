using Microsoft.AspNetCore.Mvc;
using ControlGastos.Models;
using System.Linq;

namespace ControlGastos.Controllers
{
    public class GastosController : Controller
    {
        private readonly AppDbContext _context;

        public GastosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string categoria)
        {
            var gastos = _context.Gastos.AsQueryable();

            if (!string.IsNullOrEmpty(categoria))
            {
                gastos = gastos.Where(g => g.Categoria == categoria);
            }

            var lista = gastos.ToList();

            var total = lista.Sum(g => g.Monto);
            ViewBag.Total = total;

            return View(lista);
        }

        [HttpPost]
        public IActionResult AgregarGasto(Gasto gasto)
        {
            if (ModelState.IsValid)
            {
                _context.Gastos.Add(gasto);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EliminarGasto(int id)
        {
            var gasto = _context.Gastos.Find(id);

            if (gasto != null)
            {
                _context.Gastos.Remove(gasto);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult EditarGasto(int id)
        {
            var gasto = _context.Gastos.Find(id);

            if (gasto == null)
            {
                return NotFound();
            }

            return View(gasto);
        }

        [HttpPost]
        public IActionResult EditarGasto(Gasto gasto)
        {
            if (ModelState.IsValid)
            {
                _context.Gastos.Update(gasto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gasto);
        }
    }
}
