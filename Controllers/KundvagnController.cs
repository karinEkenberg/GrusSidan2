using GrusSidan.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrusSidan.Controllers
{
    public class KundvagnController : Controller
    {
        private readonly GrusDbContext _context;

        public KundvagnController(GrusDbContext context)
        {
            _context = context;
        }

        public IActionResult ViewCart()
        {
            List<Product> products = _context.Products.ToList(); // Konvertera till lista
            ViewData["Title"] = "Produkter";

            // Skicka med listan av produkter till vyn
            return View(products);
        }

        [HttpPost]
        public IActionResult AddToCart(int productID, int quantity)
        {

            _context.Products.Add(new Product { });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromCart (int productID)
        {
            _context.Products.Remove(new Product { });
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
