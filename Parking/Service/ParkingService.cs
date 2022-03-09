using Models;
using MySqlConnector;
using Parking.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking.Service
{
    public class ParkingService : IParkingService
    {
        private readonly ApplicationDbContext db;

        public ParkingService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<ParkingInListViewModel> GetAll(int id, int items)
        {
            var parkings = this.db.Parkings.Skip((id - 1) * items).Take(items)
                 .Select(x => new ParkingInListViewModel
                 {
                     Id = x.Id,
                     Name = x.Name,                     
                     ImageURL = "/img/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension
                 }).ToList();
            return parkings;
        }
        public int GetCount()
        {
            return db.Parkings.Count();
        }
        public SingleParkingViewModel GetById(int id)
        {
            var parking = this.db.Parkings.Where(x => x.Id == id).Select(x => new SingleParkingViewModel
            {
                Name = x.Name,
                Address = x.Address,
                CountPlace = x.CountPlace,
                Price = x.Price,
                Price12h = x.Price12h,
                Price24h = x.Price24h,
                ParkingType = x.ParkingType,
                ImageURL = "/img/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension
            }).FirstOrDefault();
            return parking;
        }
        public IEnumerable<ParkingPriceViewModel> GetPrice()
        {
            
            
           var parkings = this.db.Parkings
                 .Select(x => new ParkingPriceViewModel
                 {
                    
                     Name = x.Name,
                     Price = x.Price,
                     Price12h = x.Price12h,
                     Price24h = x.Price24h                   
                 }).ToList();
           
            List<ParkingPriceViewModel> app = new List<ParkingPriceViewModel>();
            using (var connection = new MySqlConnection("Server=pyrolands.ddns.net;Database=parkingdb;Uid=Frontend;Pwd=aUqFec6veCD2eWwWbUrK74anN6mVfkXu;"))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM parkings;", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParkingPriceViewModel model = new ParkingPriceViewModel();
                        
                        model.Name = reader["Name"].GetType() != typeof(DBNull) ? (string)reader["Name"] : null;
                        
                        model.Type = reader["Type"].GetType() != typeof(DBNull) ? (string)reader["Type"] : null;
                        var a = this.db.Parkings.Select(x => new ParkingPriceViewModel
                        {
                            Price12h = x.Price12h
                        }).ToList();
                        app.Add(model);
                    }
                }
            }

            return app;
            
        }
        public IEnumerable<AppParkingViewModel> GetApp()
        {
            List<AppParkingViewModel> app = new List<AppParkingViewModel>();
            using (var connection = new MySqlConnection("Server=pyrolands.ddns.net;Database=parkingdb;Uid=Frontend;Pwd=aUqFec6veCD2eWwWbUrK74anN6mVfkXu;"))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM parkings;", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AppParkingViewModel model = new AppParkingViewModel();

                        model.Id = reader["Id"].GetType() != typeof(DBNull) ? (string)reader["Id"] : null;
                        model.Name = reader["Name"].GetType() != typeof(DBNull) ? (string)reader["Name"] : null;
                        model.Address = reader["Address"].GetType() != typeof(DBNull) ? (string)reader["Address"] : null;
                        model.GpsLat = reader["GPS Lat"].GetType() != typeof(DBNull) ? (double)reader["GPS Lat"] : null;
                        model.GpsLng = reader["GPS Lng"].GetType() != typeof(DBNull) ? (double)reader["GPS Lng"] : null;
                        model.Total = reader["Total"].GetType() != typeof(DBNull) ? (int)reader["Total"] : null;
                        model.Free = reader["Free"].GetType() != typeof(DBNull) ? (int)reader["Free"] : null;
                        model.Type = reader["Type"].GetType() != typeof(DBNull) ? (string)reader["Type"] : null;

                        app.Add(model);
                    }
                }
            }

            return app;

           
        }
       

    }
}
