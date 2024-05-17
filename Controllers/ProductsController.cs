using GrusSidan.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace GrusSidan.Controllers
{
    public class ProductsController : Controller
    {
        private readonly GrusDbContext _context;

        public ProductsController(GrusDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList(); // Konvertera till lista
            ViewData["Title"] = "Produkter";
            return View(products);
        }

    }
}
