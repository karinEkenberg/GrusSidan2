using GrusSidan.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
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

        public IActionResult SendEmail()
        {
            ViewData["Title"] = "SendEmail";
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
                    smtpClient.Credentials = new NetworkCredential("karin@mixvision.se", "your-password");

                    // Skapa e-postmeddelandet
                    var mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("karin@mixvision.se");
                    mailMessage.To.Add("recipient@example.com");
                    mailMessage.Subject = "Fråga från webbplatsen";
                    mailMessage.Body = $"Namn: {name}\nE-post: {email}\nFråga: {question}";

                    // Skicka e-postmeddelandet
                    smtpClient.Send(mailMessage);

                    ViewBag.Message = "Ditt meddelande har skickats. Vi återkommer så snart som möjligt.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Något gick fel. Vänligen försök igen senare.";
            }

            return View();
        }
    }
}
