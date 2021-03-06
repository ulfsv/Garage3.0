﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GarageMVC.Models;
using GarageMVC.Models.Entities;

namespace GarageMVC.Data
{
    public class GarageMVCContext : DbContext
    {
        public GarageMVCContext (DbContextOptions<GarageMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ParkedVehicle> ParkedVehicle { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Spot> Spots { get; set; }
        public DbSet<VehicleType2> VehicleType2s { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ParkedVehicle>()
            //    .HasData(
            //        new ParkedVehicle { Id = 1, VehicleType = VehicleType.Car, LicenceNr = "BIL111", Brand = "Volkswagen", Color = "Grey", Model = "Golf", NrOfWheels = 4, ArrivalTime =                DateTime.Now.AddDays(-1.0), StartLocation = 0},
            //        new ParkedVehicle { Id = 2, VehicleType = VehicleType.Motorcycle, LicenceNr = "MOT111", Brand = "Ducati", Color = "Red", Model = "Retro", NrOfWheels = 2, ArrivalTime =             DateTime.Now.AddDays(-1.0), StartLocation = 1},
            //        new ParkedVehicle { Id = 3, VehicleType = VehicleType.Airplane, LicenceNr = "AIR111", Brand = "Boeing", Color = "White", Model = "777", NrOfWheels = 12, ArrivalTime =              DateTime.Now.AddDays(-2.0), StartLocation = 2},
            //        new ParkedVehicle { Id = 4, VehicleType = VehicleType.Boat, LicenceNr = "BOA111", Brand = "Bertram", Color = "White", Model = "31 Flybridge Cruiser", NrOfWheels = 0, ArrivalTime = DateTime.Now.AddDays(-3.0), StartLocation = 5},
            //        new ParkedVehicle { Id = 5, VehicleType = VehicleType.Bus, LicenceNr = "BUS111", Brand = "Mercedes Benz", Color = "Red", Model = "Citario", NrOfWheels = 4, ArrivalTime =           DateTime.Now.AddDays(-4.0), StartLocation = 8},
            //        new ParkedVehicle { Id = 6, VehicleType = VehicleType.Car, LicenceNr = "BIL222", Brand = "Mercedes Benz", Color = "Black", Model = "C-Class", NrOfWheels = 4, ArrivalTime =         DateTime.Now.AddDays(-5.0), StartLocation = 10},
            //        new ParkedVehicle { Id = 7, VehicleType = VehicleType.Motorcycle, LicenceNr = "MOT222", Brand = "BMW", Color = "Green", Model = "S 1000 RR", NrOfWheels = 2, ArrivalTime =          DateTime.Now.AddDays(-6.0), StartLocation = 11},
            //        new ParkedVehicle { Id = 8, VehicleType = VehicleType.Airplane, LicenceNr = "AIR222", Brand = "SAAB", Color = "Grey", Model = "Gripen", NrOfWheels = 3, ArrivalTime =               DateTime.Now.AddDays(-7.0), StartLocation = 12},
            //        new ParkedVehicle { Id = 9, VehicleType = VehicleType.Boat, LicenceNr = "BOA222", Brand = "Sea Ray", Color = "White", Model = "SLX 400 OB", NrOfWheels = 0, ArrivalTime =           DateTime.Now.AddDays(-8.0), StartLocation = 15},
            //        new ParkedVehicle { Id = 10, VehicleType = VehicleType.Bus, LicenceNr = "BUS222", Brand = "Man", Color = "Blue", Model = "SR 240", NrOfWheels = 4, ArrivalTime =                    DateTime.Now.AddDays(-9.0), StartLocation = 18}


            //    );

            modelBuilder.Entity<VehicleType2>().HasData(
                new VehicleType2 { Id = 1, Name = "Motorcycle", Size = 1 },
                 new VehicleType2 { Id = 2, Name = "Car", Size = 1 },
                  new VehicleType2 { Id = 3, Name = "Bus", Size = 2 },
                   new VehicleType2 { Id = 4, Name = "Airplane", Size = 3 });
            modelBuilder.Entity<Member>().HasData(new Member { Id = 1, FirstName = "Billy", LastName = "Buch", Email = "bill@gmail.com", UserName = "BBch" },
                new Member { Id = 2, FirstName = "Ivan", LastName = "Araque", Email = "ivan@gmail.com", UserName = "MrCaton" },
                new Member { Id = 3, FirstName = "David", LastName = "Nokto", Email = "david@gmail.com", UserName = "D.Nokto" },
                new Member { Id = 4, FirstName = "Mats", LastName = "Nilsson", Email = "mats@gmail.com", UserName = "Matslearning" });
            //modelBuilder.Entity<Vehicle>().HasData(
            //    new Vehicle {Id=1, LicenceNr="CARBBC", Color="Green", Brand="Opel", Model="Corsa", NrOfWheels=4,ArrivalTime = DateTime.Now.AddDays(-7.0) , VehicleType2Id=2, MemberId=1},
            //    new Vehicle { Id = 2, LicenceNr = "NAVI94", Color = "Black", Brand = "Volvo", Model = "XC90", NrOfWheels = 4, ArrivalTime = DateTime.Now.AddDays(-5.0), VehicleType2Id = 2, MemberId = 2 },
            //    new Vehicle { Id = 3, LicenceNr = "SKTHMH", Color = "Black", Brand = "Yamaha", Model = "Super", NrOfWheels = 2, ArrivalTime = DateTime.Now.AddDays(-2.0), VehicleType2Id = 1, MemberId = 3 },
            //    new Vehicle { Id = 4, LicenceNr = "BUSBUS", Color = "Blue", Brand = "Mercedes", Model = "Ultra", NrOfWheels = 10, ArrivalTime = DateTime.Now.AddDays(-1.0), VehicleType2Id = 3, MemberId = 4 }
                //);

            //modelBuilder.Entity<Member>().HasData(
            //new Member { Id = 1, FirstName = "Nelson", LastName = "Mandela", Email = "nelsonmandela@gmail.com", UserName = "Nmandela" },
            //new Member { Id = 2, FirstName = "Billy", LastName = "Buch", Email = "bill@gmail.com", UserName = "BBch" }
            //);



            //modelBuilder.Entity<Vehicle>().HasData(
            //    new Vehicle { Id = 1, LicenceNr = "ABC111", Brand = "Brand1", Model = "Model1", Color = "Black", NrOfWheels = 4, ArrivalTime = DateTime.Now.AddDays(-1.0), VehicleType2 = a, Member = b },
            //    new Vehicle { Id = 2, LicenceNr = "ABC222", Brand = "Brand2", Model = "Model2", Color = "White", NrOfWheels = 4, ArrivalTime = DateTime.Now.AddDays(-2.0), VehicleType2 = a, Member = b }
            //    );




        }

        //public DbSet<GarageMVC.Models.Entities.Member> Member { get; set; }
    }
}
