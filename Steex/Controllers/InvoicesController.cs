using Microsoft.AspNetCore.Mvc;

namespace Skote.Controllers
{
    public class InvoicesController : Controller
    {
        // GET: Invoices
        public IActionResult create()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
        public IActionResult OverView()
        {
            return View();
        }
    }
}