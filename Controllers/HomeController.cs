using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webdev_consultationPhotovoltaique.Models;

namespace webdev_consultationPhotovoltaique.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;


        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult about1()
        {
            return View();
        }
        public IActionResult feedback()
        {
            return View();
        }
        public IActionResult termes()
        {
            return View();
        }
        public IActionResult profil()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Logout()
        {
            // Clear all session variables
            _contextAccessor.HttpContext.Session.Clear();
            return RedirectToAction("Index"); // Redirects to Home/Index
        }
    }
}
