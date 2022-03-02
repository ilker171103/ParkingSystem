namespace Parking.Models
{
    public class SingleParkingViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CountPlace { get; set; }
        public int FreePlace { get; set; }
        public double Price { get; set; }
        public double Price12h { get; set; }
        public double Price24h { get; set; }
        public string ParkingType { get; set; }
        public string ImageURL { get; set; }


    }
}
