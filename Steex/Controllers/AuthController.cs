using Microsoft.AspNetCore.Mvc;

namespace Skote.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public IActionResult auth404()
        {
            return View();
        }

        public IActionResult auth500()
        {
            return View();
        }

        public IActionResult auth503()
        {
            return View();
        }

        public IActionResult LockScreen()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult Offline()
        {
            return View();
        }

        public IActionResult change()
        {
            return View();
        }

        public IActionResult reset()
        {
            return View();
        }

        public IActionResult signin()
        {
            return View();
        }

        public IActionResult signup()
        {
            return View();
        }

        public IActionResult successmsg()
        {
            return View();
        }

        public IActionResult twostep()
        {
            return View();
        }

    }
}