using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Parking.Models
{
    public class CreateParkingViewModel
    {
       
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double GPSLat { get; set; }
        public double GPSLng { get; set; }
        public int Total { get; set; }
        public int Free { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        //public string[] Types = new[] { "безплатен", "платен" };
        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
        public IFormFile Image { get; set; }
    }
}
