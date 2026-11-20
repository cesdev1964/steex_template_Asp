using Microsoft.AspNetCore.Mvc;

namespace Skote.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult analytics()
        {
            return View();
        }

        public IActionResult crm()
        {
            return View();
        }
        public IActionResult learning()
        {
            return View();
        }

        public IActionResult realestate()
        {
            return View();
        }


    }
}