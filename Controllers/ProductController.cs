using GrusSidan.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GrusSidan.Controllers
{
    public class ProductController : Controller
    {
        private readonly GrusDbContext _context;

        public ProductController(GrusDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.Include(p => p.Category).ToList(); // Fetch all products including their categories
            ViewBag.Categories = _context.Categories.ToList() ?? new List<Category>();
            return View(products); // Pass the products to the view
        }

        public IActionResult Category(int categoryId)
        {
            var productsInCategory = _context.Products
                                              .Where(p => p.CategoryID == categoryId)
                                              .ToList();

            return View(productsInCategory);
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products
                                   .Include(p => p.Category)
                                   .FirstOrDefault(p => p.ProductID == id);

            if (product == null)
            {
                return NotFound();
            }

            var relatedProducts = _context.Products
                                            .Where(p => p.CategoryID == product.CategoryID && p.ProductID != id)
                                            .ToList();

            ViewData["RelatedProducts"] = relatedProducts;

            return View(product);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            // Hantera logiken för att lägga till produkten i kundvagnen här

            return RedirectToAction("cart"); // Omdirigera till kundvagnssidan efter att produkten har lagts till
        }

        public IActionResult EmptyCart()
        {
            ViewData["Title"] = "Tom kundvagn";
            return View();
        }
    }
}
