using Microsoft.AspNetCore.Mvc;
using Parking.Models;
using Parking.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Controllers
{
    public class PriceController : Controller
    {
        private readonly IParkingService parkingService;

        public PriceController(IParkingService parkingService)
        {
            this.parkingService = parkingService;
        }
        public IActionResult All(int id = 1)
        {
            int count = this.parkingService.GetCount();
            var viewModel = new ParkingAllPriceViewModel
            {
                 
                Names = this.parkingService.GetPrice()
                
                //PageNumber = id,
                //Parkings = this.parkingService.GetAll(id, 12),
                //ParksPerPage = 12,
                 
            };
            return this.View(viewModel);
        }
    }
}
