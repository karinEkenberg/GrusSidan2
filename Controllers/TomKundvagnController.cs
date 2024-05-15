using Microsoft.AspNetCore.Mvc;

namespace GrusSidan.Controllers
{
    public class TomKundvagnController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Tom kundvagn";
            return View();
        }
    }
}
