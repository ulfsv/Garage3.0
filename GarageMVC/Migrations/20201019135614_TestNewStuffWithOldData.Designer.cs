﻿// <auto-generated />
using System;
using GarageMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GarageMVC.Migrations
{
    [DbContext(typeof(GarageMVCContext))]
    [Migration("20201019135614_TestNewStuffWithOldData")]
    partial class TestNewStuffWithOldData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GarageMVC.Models.ParkedVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenceNr")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("NrOfWheels")
                        .HasColumnType("int");

                    b.Property<int>("StartLocation")
                        .HasColumnType("int");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParkedVehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalTime = new DateTime(2020, 10, 18, 15, 56, 13, 645, DateTimeKind.Local).AddTicks(2440),
                            Brand = "Volkswagen",
                            Color = "Grey",
                            LicenceNr = "BIL111",
                            Model = "Golf",
                            NrOfWheels = 4,
                            StartLocation = 0,
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 2,
                            ArrivalTime = new DateTime(2020, 10, 18, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5364),
                            Brand = "Ducati",
                            Color = "Red",
                            LicenceNr = "MOT111",
                            Model = "Retro",
                            NrOfWheels = 2,
                            StartLocation = 0,
                            VehicleType = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalTime = new DateTime(2020, 10, 17, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5405),
                            Brand = "Boeing",
                            Color = "White",
                            LicenceNr = "AIR111",
                            Model = "777",
                            NrOfWheels = 12,
                            StartLocation = 0,
                            VehicleType = 3
                        },
                        new
                        {
                            Id = 4,
                            ArrivalTime = new DateTime(2020, 10, 16, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5411),
                            Brand = "Bertram",
                            Color = "White",
                            LicenceNr = "BOA111",
                            Model = "31 Flybridge Cruiser",
                            NrOfWheels = 0,
                            StartLocation = 0,
                            VehicleType = 4
                        },
                        new
                        {
                            Id = 5,
                            ArrivalTime = new DateTime(2020, 10, 15, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5415),
                            Brand = "Mercedes Benz",
                            Color = "Red",
                            LicenceNr = "BUS111",
                            Model = "Citario",
                            NrOfWheels = 4,
                            StartLocation = 0,
                            VehicleType = 2
                        },
                        new
                        {
                            Id = 6,
                            ArrivalTime = new DateTime(2020, 10, 14, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5419),
                            Brand = "Mercedes Benz",
                            Color = "Black",
                            LicenceNr = "BIL222",
                            Model = "C-Class",
                            NrOfWheels = 4,
                            StartLocation = 0,
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 7,
                            ArrivalTime = new DateTime(2020, 10, 13, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5424),
                            Brand = "BMW",
                            Color = "Green",
                            LicenceNr = "MOT222",
                            Model = "S 1000 RR",
                            NrOfWheels = 2,
                            StartLocation = 0,
                            VehicleType = 1
                        },
                        new
                        {
                            Id = 8,
                            ArrivalTime = new DateTime(2020, 10, 12, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5427),
                            Brand = "SAAB",
                            Color = "Grey",
                            LicenceNr = "AIR222",
                            Model = "Gripen",
                            NrOfWheels = 3,
                            StartLocation = 0,
                            VehicleType = 3
                        },
                        new
                        {
                            Id = 9,
                            ArrivalTime = new DateTime(2020, 10, 11, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5431),
                            Brand = "Sea Ray",
                            Color = "White",
                            LicenceNr = "BOA222",
                            Model = "SLX 400 OB",
                            NrOfWheels = 0,
                            StartLocation = 0,
                            VehicleType = 4
                        },
                        new
                        {
                            Id = 10,
                            ArrivalTime = new DateTime(2020, 10, 10, 15, 56, 13, 648, DateTimeKind.Local).AddTicks(5436),
                            Brand = "Man",
                            Color = "Blue",
                            LicenceNr = "BUS222",
                            Model = "SR 240",
                            NrOfWheels = 4,
                            StartLocation = 0,
                            VehicleType = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}