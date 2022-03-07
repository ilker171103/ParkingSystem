using Parking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Service
{
    public interface IGetFreePlacesService
    {
        public IEnumerable<FreePlacesViewModel> GetFreePlaces(int id, int items);
    }
}
