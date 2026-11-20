using Microsoft.AspNetCore.Mvc;

namespace Steex.Controllers
{
    public class TicketsController : Controller
    {
        // GET: Tickets
        public IActionResult list()
        {
            return View();
        }
        public IActionResult overview()
        {
            return View();
        }
    }
}