using AppDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppDemo.Controllers
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

        public IActionResult Map()
        {
            return View(new Coordinates
            {
                Lon = 50.3288982,                
                Lat = 26.4935626
            });
        }
        [HttpGet]
        public IActionResult SetMarker()
        {
            return View(new Coordinates
            {
                Lon = 50.3288982,
                Lat = 26.4935626
            });
        }

        [HttpPost]
        public IActionResult SetMarker(IFormCollection collection, string lat, string lon)
        {
            var coords = new Coordinates
            {
                Lon = double.Parse(lon),
                Lat = double.Parse(lat)
            };

            return View("Map", coords);
        }

        public IActionResult Privacy()
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
