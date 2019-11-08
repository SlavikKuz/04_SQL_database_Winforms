﻿// <auto-generated />
using System;
using HotelDb.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelDb.DataLayer.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20191108094138_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview2.19525.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelDb.DataLayer.Entities.BookedRoomsListDL", b =>
                {
                    b.Property<long>("BookingId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomId")
                        .HasColumnType("bigint");

                    b.HasKey("BookingId", "RoomId");

                    b.ToTable("BookedRoomsList");
                });

            modelBuilder.Entity("HotelDb.DataLayer.Entities.BookingDL", b =>
                {
                    b.Property<long>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookingInfo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("BookingStatus")
                        .HasColumnType("int");

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DayFrom")
                        .HasColumnType("date");

                    b.Property<DateTime>("DayTill")
                        .HasColumnType("date");

                    b.Property<long>("InvoiceId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date");

                    b.Property<bool>("WithKids")
                        .HasColumnType("bit");

                    b.HasKey("BookingId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("HotelDb.DataLayer.Entities.ClientDL", b =>
                {
                    b.Property<long>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ClientInfo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("HotelDb.DataLayer.Entities.GuestsListDL", b =>
                {
                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<long>("BookingId")
                        .HasColumnType("bigint");

                    b.HasKey("ClientId", "BookingId");

                    b.ToTable("GuestsList");
                });

            modelBuilder.Entity("HotelDb.DataLayer.Entities.HolidaysListDL", b =>
                {
                    b.Property<DateTime>("HolidayDay")
                        .HasColumnType("date");

                    b.Property<string>("HolidayName")
                        .HasColumnType("nvarchar(20)");

                    b.ToTable("HolidaysList");
                });

            modelBuilder.Entity("HotelDb.DataLayer.Entities.InvoiceDL", b =>
                {
                    b.Property<long>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BookingId")
                        .HasColumnType("bigint");

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("HotelDb.DataLayer.Entities.RoomDL", b =>
                {
                    b.Property<long>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("NumberBeds")
                        .HasColumnType("int");

                    b.Property<bool>("Ready")
                        .HasColumnType("bit");

                    b.Property<string>("RoomInfo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelDb.DataLayer.Entities.RoomPriceDL", b =>
                {
                    b.Property<long>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AveragePrice")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("HolidayPrice")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("WeekendPrice")
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("RoomId");

                    b.ToTable("RoomPrices");
                });
#pragma warning restore 612, 618
        }
    }
}
