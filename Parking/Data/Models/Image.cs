using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Image
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; } //Name = Id
        public string Extension { get; set; }
        
        [ForeignKey("Park")]
        public int ParkingId { get; set; }
        public virtual CarParking Parking { get; set; }
    }
}
