using Models;
using Parking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Service
{
    public class GetFreePlacesService : IGetFreePlacesService
    {
        private readonly ApplicationDbContext db;

        public GetFreePlacesService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<FreePlacesViewModel> GetFreePlaces(int id, int items)
        {
            var parkings = this.db.Parkings.Skip((id - 1) * items).Take(items)
                .Select(x => new FreePlacesViewModel
                {
                    Name = x.Name,
                    CountPlace = x.CountPlace,
                    FreePlace = x.FreePlace
                }).ToList();
            return parkings;
        }
    }
}
