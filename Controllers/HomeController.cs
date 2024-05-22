using GrusSidan.Classes;
using GrusSidan.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace GrusSidan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GrusDbContext _context;

        public HomeController(ILogger<HomeController> logger, GrusDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            return View(categories);
        }


        public IActionResult OmOss()
        {
            ViewData["Title"] = "Om oss";
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult SendEmail()
        {
            ViewData["Title"] = "Meddelande skickat";
            return View();
        }

        public ActionResult Sent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendEmail(string name, string email, string question)
        {
            try
            {
                // Skapa en instans av SmtpClient med e-postleverantörens inställningar
                using (var smtpClient = new SmtpClient("smtp.example.com"))
                {
                    // Ange dina autentiseringsuppgifter för e-postservern om det behövs
                    smtpClient.Credentials = new NetworkCredential("", "your-password");

                    // Skapa e-postmeddelandet
                    var mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("");
                    mailMessage.To.Add("recipient@example.com");
                    mailMessage.Subject = "Fråga från webbplatsen";
                    mailMessage.Body = $"Namn: {name}\nE-post: {email}\nFråga: {question}";

                    // Skicka e-postmeddelandet
                    smtpClient.Send(mailMessage);

                    // E-postmeddelandet har skickats framgångsrikt, omdirigera till rätt sida
                    return RedirectToAction("SendEmail", "Home", new { area = "Kontakt" });
                }
            }
            catch (Exception ex)
            {
                // Hantera fel om något går fel vid skickande av e-post
                ViewBag.Error = "Något gick fel. Vänligen försök igen senare.";
                return View();
            }
        }

    }
}
