using Microsoft.AspNetCore.Mvc;

namespace GrusSidan.Controllers
{
    public class KundvagnController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Kundvagn";
            return View();
        }
    }
}
