using Models;
using System.Collections.Generic;
using System.Linq;

namespace Parking.Service
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext db;

        public CategoriesService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<KeyValuePair<string, string>> GetCategories()
        {
            return db.Categories.Select(x => new { x.Id, x.Name })
               .OrderBy(x => x.Name).ToList().Select(x =>
               new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
