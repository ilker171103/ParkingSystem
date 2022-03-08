using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class AppParkingAllViewModel
    {
        public AppParkingAllViewModel()
        {
            this.Apps = new HashSet<AppParkingViewModel>();
        }
        public IEnumerable<AppParkingViewModel> Apps { get; set; }
    }
}
