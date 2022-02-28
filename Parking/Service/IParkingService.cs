using Parking.Models;
using System.Collections.Generic;

namespace Parking.Service
{
    public interface IParkingService
    {
        public IEnumerable<ParkingInListViewModel> GetAll(int countRecipe, int pageNumber);
        public IEnumerable<ParkingPriceViewModel> GetPrice();
        public int GetCount();
        public SingleParkingViewModel GetById(int id);
    }
}
