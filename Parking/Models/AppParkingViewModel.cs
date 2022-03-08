using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class AppParkingViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double? GpsLat { get; set; }
        public double? GpsLng { get; set; }
        public int? Total { get; set; }
        public int? Free { get; set; }
        public string Type { get; set; }
    }
}
