using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class ParkingAllPriceViewModel
    {
        public ParkingAllPriceViewModel()
        {
            this.Names = new HashSet<ParkingPriceViewModel>();
        }
        public IEnumerable<ParkingPriceViewModel> Names { get; set; }

    }
}
