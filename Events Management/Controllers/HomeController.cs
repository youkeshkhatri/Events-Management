using Events_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Events_Management.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        } 
        
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult photographer()
        {
            return View();
        }

        public IActionResult graphicdesigning()
        {
            return View();
        }

        public IActionResult Themesandlocation()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}