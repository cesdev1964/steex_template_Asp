using Microsoft.AspNetCore.Mvc;

namespace Skote.Controllers
{
    public class LayoutsController : Controller
    {
        // GET: Layouts
        public IActionResult layoutsDetached()
        {
            return View();
        }

        public IActionResult layoutsHorizontal()
        {
            return View();
        }

        public IActionResult layoutsTwoColumn()
        {
            return View();
        }

        public IActionResult layoutsVerticalHovered()
        {
            return View();
        }

    }
}