using Microsoft.AspNetCore.Mvc;
using minibidlo.Models;
using System.Diagnostics;

namespace minibidlo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            _logger.LogInformation("Home page accessed");
            return View();
        }

        public IActionResult AboutUs()
        {
            _logger.LogInformation("About Us page accessed");
            return View();
        }

        public IActionResult Basket()
        {
            _logger.LogInformation("Basket page accessed");
            return View();
        }

        public IActionResult Products()
        {
            _logger.LogInformation("Products page accessed");
            return View();
        }

        public IActionResult Profile()
        {
            _logger.LogInformation("Profile page accessed");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogError("An error occurred");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
