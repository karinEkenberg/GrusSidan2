using Microsoft.AspNetCore.Mvc;

namespace GrusSidan.Controllers
{
    public class OmOssController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Om oss";
            return View();
        }
    }

}
