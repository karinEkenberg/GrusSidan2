using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace GrusSidan.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Produkter";
            return View();
        }
    }
}
