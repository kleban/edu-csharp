using AppDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using X.PagedList;

namespace AppDemo.Controllers
{
    public class HomeController : Controller
    {
        private const int pageSize = 3;
        private readonly ILogger<HomeController> _logger;

        List<Demo> data = new List<Demo>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;            
            for (int i = 1; i < 30; i++)
                data.Add(new Demo { Id = i, Name = $"Name_{i}" });
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetJson() 
        { 
            HttpClient client = new HttpClient();
            MyJsonObject data = await client.GetFromJsonAsync<MyJsonObject>("https://callook.info/W1AW/json");
            return View(data);
        }

        public class Demo
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public async Task<IActionResult> Paging(int? page)
        {
            // return a 404 if user browses to before the first page
            page = page ?? 1;

            if (page < 1)
            {
                return NotFound();
            }
                        
            var records = await data.ToPagedListAsync((int)page, pageSize);

            // return a 404 if user browses to pages beyond last page. special case first page if no items exist
            if (records.PageNumber != 1 && page > records.PageCount)
            {
                return NotFound();
            }

            return View(records);
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
