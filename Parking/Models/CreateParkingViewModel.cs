using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Parking.Models
{
    public class CreateParkingViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CountPlace { get; set; }
        public int FreePlace { get; set; }
        public double Price { get; set; }
        public double Price12h { get; set; }
        public double Price24h { get; set; }
        public string ParkingType { get; set; }
        public string[] ParkingTypes = new[] { "PaidParking", "FreeParking" };
        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
        public IFormFile Image { get; set; }
    }
}
