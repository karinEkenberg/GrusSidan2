using Microsoft.AspNetCore.Mvc;

namespace GrusSidan.Controllers
{
    public class KundvagnController : Controller
    {
        private List<CartItem> cartItems;

        public IActionResult Index()
        {
            ViewData["Title"] = "Kundvagn"; 
            var cartItems = GetCartItemsFromSession();
            return View(cartItems);
        }

        private List<CartItem> GetCartItemsFromSession()
        {
            // Hämta kundvagnens innehåll från sessionen
            // Exempel: List<CartItem> cartItems = HttpContext.Session.Get<List<CartItem>>("Cart");
            // Om du använder sessionsvariabler för kundvagnens innehåll
            return cartItems;
        }
    }
}
