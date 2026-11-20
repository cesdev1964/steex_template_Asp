using Microsoft.AspNetCore.Mvc;

namespace Steex.Controllers
{
    public class LearningController : Controller
    {
        // GET: Learning
        public IActionResult category()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        public IActionResult grid()
        {
            return View();
        }
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