using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Parking.Data;
using Parking.Data.Models;
using Parking.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            this.db = db;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateParkingViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }
            Park parking = new Park
            {
                Name = input.Name,
                Address = input.Address,
                CountPlace = input.CountPlace,
                Price = input.Price,
                ProductType = input.ProductType
            };
            this.db.Parkings.Add(parking);
            this.db.SaveChanges();
            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
