using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parking.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }
        public DbSet<Park> Parkings { get; set; }
    }
}
