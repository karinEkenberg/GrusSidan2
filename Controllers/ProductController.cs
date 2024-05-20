using GrusSidan.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

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
            List<Product> products = _context.Products.ToList();
            ViewData["Title"] = "Produkter";
            return View(products);
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

    }
}
