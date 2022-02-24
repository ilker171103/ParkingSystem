﻿using Models;
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
                ProductType = x.ProductType,
                ImageURL = "/img/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension

            }).FirstOrDefault();
            return parking;
        }



    }
}