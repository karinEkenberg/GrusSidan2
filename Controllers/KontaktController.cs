using GrusSidan.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace GrusSidan.Controllers
{
    public class KontaktController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Kontakt";
            return View();
        }
    }
}
