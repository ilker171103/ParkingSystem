namespace Parking.Models
{
    public class ParkingInListViewModel
    {
        public string Id { get; set; }
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double? GpsLat { get; set; }
        public double? GpsLng { get; set; }
        public int? CategoryId { get; set; }
        public int? Total { get; set; }
        public int? Free { get; set; }
        public string Type { get; set; }
        public string CategoryName { get; set; }
    }
}
