using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleLocation.Models
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Location> locations { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,

                    longitude = 85.301498,
                    latitude = 27.7581464,
                    IpAddress = "111.119.43.77",
                    RouteName = "jaranku"



                }

                 );
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    id = 1,
                    IpAddress = "111.119.43.77",
                    RouteName = "jaranku"
                }
                );


        }
    }
    }
