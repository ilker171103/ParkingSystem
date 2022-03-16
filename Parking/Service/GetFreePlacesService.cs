using Models;
using MySqlConnector;
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
            /*var parkings = this.db.Parkings.Skip((id - 1) * items).Take(items)
                .Select(x => new FreePlacesViewModel
                {
                    Name = x.Name,
                    CountPlace = x.CountPlace,
                    FreePlace = x.FreePlace
                }).ToList();
            return parkings;*/
            List<FreePlacesViewModel> app = new List<FreePlacesViewModel>();
            using (var connection = new MySqlConnection("Server=pyrolands.ddns.net;Database=parkingdb;Uid=Frontend;Pwd=aUqFec6veCD2eWwWbUrK74anN6mVfkXu;"))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM parkings;", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FreePlacesViewModel model = new FreePlacesViewModel();

                        
                        model.Name = reader["Name"].GetType() != typeof(DBNull) ? (string)reader["Name"] : null;
                      
                       
                        model.Total = reader["Total"].GetType() != typeof(DBNull) ? (int)reader["Total"] : null;
                        model.Free = reader["Free"].GetType() != typeof(DBNull) ? (int)reader["Free"] : null;
                        if (model.Free < 0)
                        {
                            model.Free = 0;
                        }

                        app.Add(model);
                    }
                }
            }

            return app;

        }
    }
}
