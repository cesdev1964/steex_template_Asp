using Microsoft.AspNetCore.Mvc;

namespace Steex.Controllers
{
    public class WidgetsController : Controller
    {
        // GET: Widgets
        public IActionResult Index()
        {
            return View();
        }
    }
}