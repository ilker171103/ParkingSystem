using System;
using System.Collections.Generic;

namespace Parking.Models
{
    public class ParkingListViewModel
    {
        public int PageNumber { get; set; }
        public IEnumerable<ParkingInListViewModel> Parkings { get; set; }
        public int ParkingsCount { get; set; }
        public int ParksPerPage { get; set; }
        public int PagesCount => (int)Math.Ceiling((double)this.ParkingsCount / ParksPerPage);
        public int PreviousPageNumber => PageNumber - 1;
        public int NextPageNumber => PageNumber + 1;
        public bool HasPreviousPage => this.PageNumber > 1;
        public bool HasNextPage => this.PageNumber < this.PagesCount;
    }
}
