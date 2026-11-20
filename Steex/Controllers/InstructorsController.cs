using Microsoft.AspNetCore.Mvc;

namespace Steex.Controllers
{
    public class InstructorsController : Controller
    {
        // GET: Instructors
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