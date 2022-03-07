using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class FreePlacesAllViewModel
    {
        public FreePlacesAllViewModel()
        {
            this.Places = new HashSet<FreePlacesViewModel>();
        }
        public IEnumerable<FreePlacesViewModel> Places { get; set; }
        public int PageNumber { get; set; }
    }
}
