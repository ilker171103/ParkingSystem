using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Models;
using Parking.Models;
using Parking.Service;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ILogger<HomeController> _logger;
        private readonly IParkingService parkingService;
        private readonly string[] allowedExtensions = new[] { "png", "jpg" };
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ICategoriesService service;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, IParkingService parkingService, IWebHostEnvironment webHostEnvironment, ICategoriesService service)
        {
            this.db = db;
            _logger = logger;
            this.parkingService = parkingService;
            this.webHostEnvironment = webHostEnvironment;
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
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
