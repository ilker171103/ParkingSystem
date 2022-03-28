using Models;
using MySqlConnector;
using Parking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            List<ParkingInListViewModel> app = new List<ParkingInListViewModel>();
            using (var connection = new MySqlConnection("Server=localhost;Database=parkingdb;Uid=Frontend;Pwd=aUqFec6veCD2eWwWbUrK74anN6mVfkXu;"))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM parkings;", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParkingInListViewModel model = new ParkingInListViewModel();

                        model.Id = reader["Id"].GetType() != typeof(DBNull) ? (string)reader["Id"] : null;
                        model.Name = reader["Name"].GetType() != typeof(DBNull) ? (string)reader["Name"] : null;
                        
                        app.Add(model);
                    }
                }
            }

            var parkings = app.Skip((id - 1) * items).Take(items)
                 .Select(x => new ParkingInListViewModel
                 {
                     Id = x.Id,
                     Name = x.Name,
                     ImageURL = "/img/" + x.Id + ".png"
                 }).ToList();
            return parkings;
        }

        //public IEnumerable<ParkingInListViewModel> GetAll(int name)
        //{
        //    var parkings = this.db.Parkings.Skip((id - 1) * items).Take(items)
        //         .Select(x => new ParkingInListViewModel
        //         {
        //             Id = x.Id,
        //             Name = x.Name,
        //             ImageURL = "/img/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension
        //         }).ToList();
        //    return parkings;
        //}

        public int GetCount()
        {
            return db.Parkings.Count();
        }
        public SingleParkingViewModel GetById(string id)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=parkingdb;Uid=Frontend;Pwd=aUqFec6veCD2eWwWbUrK74anN6mVfkXu;"))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM parkings;", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParkingInListViewModel model = new ParkingInListViewModel();

                        model.Id = reader["Id"].GetType() != typeof(DBNull) ? (string)reader["Id"] : null;
                        model.Name = reader["Name"].GetType() != typeof(DBNull) ? (string)reader["Name"] : null;
                        model.Address = reader["Address"].GetType() != typeof(DBNull) ? (string)reader["Address"] : null;
                        model.GpsLat = reader["GPS Lat"].GetType() != typeof(DBNull) ? (double)reader["GPS Lat"] : null;
                        model.GpsLng = reader["GPS Lng"].GetType() != typeof(DBNull) ? (double)reader["GPS Lng"] : null;
                        model.Total = reader["Total"].GetType() != typeof(DBNull) ? (int)reader["Total"] : null;
                        model.Free = reader["Free"].GetType() != typeof(DBNull) ? (int)reader["Free"] : null;
                        model.Type = reader["Type"].GetType() != typeof(DBNull) ? (string)reader["Type"] : null;

                        if (model.Id == id)
                        {
                            double pricePerHour = -1;
                            if (model.Type != null && model.Type != "free")
                            {
                                Regex regex = new Regex(@"paid ((?:\d+.\d+)|(?:\d+))");
                                Match match = regex.Match(model.Type);
                                pricePerHour = double.Parse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                model.Type = "Free";
                            }

                            var singleParking = new SingleParkingViewModel
                            {
                                Name = model.Name,
                                Address = model.Address,
                                CountPlace = model.Total,
                                Price = pricePerHour != -1 ? pricePerHour : 0,
                                Price12h = pricePerHour != -1 ? pricePerHour * 12 : 0,
                                Price24h = pricePerHour != -1 ? pricePerHour * 24 : 0,
                                ParkingType = pricePerHour != -1 ? "Платен" : "Безплатен",
                                ImageURL = "/img/" + model.Id + ".png"
                            };
                            return singleParking;
                        }
                    }
                }
            }
            return null;
        }
        public IEnumerable<ParkingPriceViewModel> GetPrice()
        {
            
           
           
            List<ParkingPriceViewModel> app = new List<ParkingPriceViewModel>();
            using (var connection = new MySqlConnection("Server=localhost;Database=parkingdb;Uid=Frontend;Pwd=aUqFec6veCD2eWwWbUrK74anN6mVfkXu;"))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM parkings;", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParkingPriceViewModel model = new ParkingPriceViewModel();
                        
                        model.Id = reader["Id"].GetType() != typeof(DBNull) ? (string)reader["Id"] : null;
                        model.Name = reader["Name"].GetType() != typeof(DBNull) ? (string)reader["Name"] : null;
                        model.Type = reader["Type"].GetType() != typeof(DBNull) ? (string)reader["Type"] : null;
                        double pricePerHour = -1;
                        
                        if (model.Type != null && model.Type != "free")
                        {
                            Regex regex = new Regex(@"paid ((?:\d+.\d+)|(?:\d+))");
                            Match match = regex.Match(model.Type);
                            pricePerHour = double.Parse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
                            model.Type = $"{pricePerHour} лв";
                        }
                        else
                        {
                            model.Type = "Безплатен";   
                        }
                     
                        if (pricePerHour != -1)
                        {
                            model.Price12h = pricePerHour * 12;
                            model.Price24h = pricePerHour * 24;
                        }
                      
                        /*
                        CarParking carParking = new CarParking();
                        carParking.Name = model.Id; // using name as id
                        carParking.Price12h = model.Price12h;
                        carParking.Price24h = model.Price24h;

                        var parking = db.Parkings.FirstOrDefault(d => d.Name == model.Id);
                        if (parking == null)
                        {
                            this.db.Parkings.Add(carParking);
                        }
                        else
                        {
                            parking = carParking;
                        }
                        this.db.SaveChanges();*/
                        app.Add(model);
                    }
                }
            }
            return app;
        }
        public IEnumerable<AppParkingViewModel> GetApp()
        {
            List<AppParkingViewModel> app = new List<AppParkingViewModel>();
            using (var connection = new MySqlConnection("Server=localhost;Database=parkingdb;Uid=Frontend;Pwd=aUqFec6veCD2eWwWbUrK74anN6mVfkXu;"))
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
                        if (model.Free < 0)
                        {
                            model.Free = 0;
                        }
                        double pricePerHour = -1;

                        if (model.Type != null && model.Type != "free")
                        {
                            Regex regex = new Regex(@"paid ((?:\d+.\d+)|(?:\d+))");
                            Match match = regex.Match(model.Type);
                            pricePerHour = double.Parse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
                            model.Type = $"{pricePerHour} лв";
                        }
                        else
                        {
                            model.Type = "Безплатен";
                        }
                        app.Add(model);
                    }
                }
            }

            return app;

           
        }
       

    }
}
