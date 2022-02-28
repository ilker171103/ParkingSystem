using System.Collections.Generic;

namespace Models
{
    public class CarParking
    {
        public CarParking()
        {
            this.Images = new HashSet<Image>();
            FreePlace = 0;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CountPlace { get; set; }
        public int FreePlace { get; set; }
        public double Price { get; set; }
        public double Price12h { get; set; }
        public double Price24h { get; set; }
        public string ProductType { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
