using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Data.Models
{
    public class Park
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountPlace { get; set; }
        public int FreePlace { get; set; }
        public double Price { get; set; }
    }
}
