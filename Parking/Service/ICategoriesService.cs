using System.Collections.Generic;

namespace Parking.Service
{
    public interface ICategoriesService
    {
        public IEnumerable<KeyValuePair<string, string>> GetCategories();
    }
}
