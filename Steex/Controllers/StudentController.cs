using Microsoft.AspNetCore.Mvc;

namespace Steex.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public IActionResult courses()
        {
            return View();
        }
        public IActionResult subscriptions()
        {
            return View();
        }
    }
}