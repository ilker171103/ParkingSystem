using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using MySqlConnector;
using Parking.Models;
using Parking.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Controllers
{
    public class ParkingController : Controller
    {
        private readonly ApplicationDbContext db;
      
        private readonly IParkingService parkingService;
        private readonly string[] allowedExtensions = new[] { "png", "jpg" };
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ICategoriesService service;
        private readonly IGetFreePlacesService placeService;

        public ParkingController(ILogger<ParkingController> logger, ApplicationDbContext db, IParkingService parkingService, IWebHostEnvironment webHostEnvironment, ICategoriesService service, IGetFreePlacesService placeService)
        {
            this.db = db;           
            this.parkingService = parkingService;
            this.webHostEnvironment = webHostEnvironment;
            this.service = service;
            this.placeService = placeService;
        }
        public IActionResult Create()
        {
            var viewModel = new CreateParkingViewModel();
            viewModel.CategoriesItems = this.service.GetCategories();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateParkingViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }
            CarParking parking = new CarParking
            {
                Name = input.Name,
                Address = input.Address,
                CountPlace = input.CountPlace,
                Price = input.Price,
                Price12h = input.Price12h,
                Price24h = input.Price24h,
                ParkingType = input.ParkingType
            };

            var extension = Path.GetExtension(input.Image.FileName).TrimStart('.');
            if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
            {
                this.ModelState.AddModelError("Image", "Invalid file name");
            }
            var dbImage = new Image
            {
                Extension = extension
            };
            using (FileStream fs = new FileStream(this.webHostEnvironment.WebRootPath + "/img/" + dbImage.Id + "." + extension, FileMode.Create))
            {
                await input.Image.CopyToAsync(fs);
            }
            parking.Images.Add(dbImage);
            this.db.Parkings.Add(parking);
            this.db.SaveChanges();

            return Redirect("/");
        }
        public IActionResult All(int id = 1)
        {
            var viewModel = new ParkingListViewModel
            {
                PageNumber = id,
                Parkings = this.parkingService.GetAll(id, 12),
                ParksPerPage = 12,
                ParkingsCount = this.parkingService.GetCount()
            };
            return this.View(viewModel);
        }
        public IActionResult ById(int id = 1)
        {
            var recipeViewModel = this.parkingService.GetById(id);
            return View(recipeViewModel);
        }
        /*public IActionResult Price()
        {
            return View();
        }*/
        public IActionResult FreePlaces(int id = 1)
        {
            var viewModel = new FreePlacesAllViewModel 
            { 
                PageNumber = id,
                Places = this.placeService.GetFreePlaces(id, 4)
            };
            return this.View(viewModel);
        }
        public IActionResult AppWork(int id = 1)
        {
            
            var viewModel = new AppParkingAllViewModel
            {

                Apps = this.parkingService.GetApp()

                //PageNumber = id,
                //Parkings = this.parkingService.GetAll(id, 12),
                //ParksPerPage = 12,

            };
            return this.View(viewModel);
        }
       
        
        public IActionResult Delete(string id)
        {
          
            using (var connection = new MySqlConnection("Server=pyrolands.ddns.net;Database=parkingdb;Uid=Frontend;Pwd=aUqFec6veCD2eWwWbUrK74anN6mVfkXu;"))
            {
                connection.Open();

                using (var command = new MySqlCommand("DELETE FROM parkings WHERE Id = @id;", connection))
                {
                    command.Parameters.AddWithValue("Id", id);

                    command.ExecuteNonQuery();
                }
            }
            return Redirect("/Parking/AppWork");
        }
       
       
    }
}
