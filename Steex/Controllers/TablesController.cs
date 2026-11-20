using Microsoft.AspNetCore.Mvc;

namespace Skote.Controllers
{
    public class TablesController : Controller
    {
        // GET: Tables
        public IActionResult TableBasic()
        {
            return View();
        }

        public IActionResult TableDatatable()
        {
            return View();
        }

        public IActionResult TablesListjs()
        {
            return View();
        }

        public IActionResult TablesGridjs()
        {
            return View();
        }

    }
}