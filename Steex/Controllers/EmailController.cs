using Microsoft.AspNetCore.Mvc;

namespace Skote.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public IActionResult index()
        {
            return View();
        }

    }
}