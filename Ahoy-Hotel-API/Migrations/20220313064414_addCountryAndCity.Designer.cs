﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using O.AlMamoon.Mobile.APP.API.Data;

#nullable disable

namespace Ahoy_Hotel_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220313064414_addCountryAndCity")]
    partial class addCountryAndCity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<string>("IdentificationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("PaidAmount")
                        .HasColumnType("float");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3757),
                            IsDeleted = false,
                            Name = "Dubai",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3758)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3849),
                            IsDeleted = false,
                            Name = "Abu Dhabi",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3850)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3884),
                            IsDeleted = false,
                            Name = "Sharjah",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3885)
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3904),
                            IsDeleted = false,
                            Name = "Jeddah",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3905)
                        },
                        new
                        {
                            Id = 5,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3920),
                            IsDeleted = false,
                            Name = "Riyadh",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3921)
                        },
                        new
                        {
                            Id = 6,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3942),
                            IsDeleted = false,
                            Name = "Dammam",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3942)
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3700),
                            IsDeleted = false,
                            Name = "United Arab Emirates",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3719)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3739),
                            IsDeleted = false,
                            Name = "Saudi Arabia",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3740)
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("IconURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Facilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4809),
                            IconURL = "https://www.icons.com/breakfast",
                            IsDeleted = false,
                            Name = "Breakfast",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4822)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4856),
                            IconURL = "https://www.icons.com/wifi",
                            IsDeleted = false,
                            Name = "Wifi",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4856)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4866),
                            IconURL = "https://www.icons.com/parking",
                            IsDeleted = false,
                            Name = "Parking",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4866)
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4874),
                            IconURL = "https://www.icons.com/Spa",
                            IsDeleted = false,
                            Name = "Spa",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4874)
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4890),
                            Email = "yassineltayeb@live.com",
                            FullName = "Guest User",
                            IsDeleted = false,
                            Password = "$2a$11$6ORDD13KHSKViKiHDNPjkuqcWWZkqBiYIjcHfEOBEVPZid5mMWg9O",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4890)
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sheikh Rashid Road, Wafi Mall, Bur Dubai, Dubai, United Arab Emirates",
                            CityId = 1,
                            CountryId = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3967),
                            Description = "Inspired by the great pyramids of Egypt, Raffles Dubai is a stunning landmark in Dubai�s skyline. This award-winning hotel features an outdoor pool, an extensive spa and free in-room WiFi.",
                            Email = "guests@rafflesdubai.com",
                            IsDeleted = false,
                            Location = "https://www.google.com/maps/dir/25.267754,55.3475338/Raffles+Dubai/@25.247935,55.2678204,12z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x3e5f5d4a2139ede3:0x6d83d44701a241ab!2m2!1d55.3203503!2d25.227917",
                            Name = "Raffles Dubai",
                            PhoneNumber = "05555555",
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3967)
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.HotelFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelFacilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4027),
                            FacilityId = 1,
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4028)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4041),
                            FacilityId = 2,
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4041)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4051),
                            FacilityId = 3,
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4051)
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4090),
                            FacilityId = 4,
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4091)
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.HotelImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4108),
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4108),
                            Url = "https://www.images.com/image1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4209),
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4218),
                            Url = "https://www.images.com/image2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4244),
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4245),
                            Url = "https://www.images.com/image3"
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("HotelId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4262),
                            Description = "The entire experience from check-in to check out. Great staffs, room, decoration, food, facilities. Also, very nice attentions have been offered for our special occasion :)",
                            GuestId = 1,
                            HotelId = 1,
                            IsDeleted = false,
                            Rating = 5,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4263)
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("NoOfGuests")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RoomNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4286),
                            HotelId = 1,
                            IsDeleted = false,
                            NoOfGuests = 2,
                            Price = 680.0,
                            RoomNo = 101,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4286)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4299),
                            HotelId = 1,
                            IsDeleted = false,
                            NoOfGuests = 2,
                            Price = 680.0,
                            RoomNo = 102,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4299)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4309),
                            HotelId = 1,
                            IsDeleted = false,
                            NoOfGuests = 2,
                            Price = 680.0,
                            RoomNo = 103,
                            UpdatedOn = new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4309)
                        });
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Booking", b =>
                {
                    b.HasOne("Ahoy_Hotel_API.Models.Guest", "Guest")
                        .WithMany("Bookings")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahoy_Hotel_API.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Hotel", b =>
                {
                    b.HasOne("Ahoy_Hotel_API.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahoy_Hotel_API.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.HotelFacility", b =>
                {
                    b.HasOne("Ahoy_Hotel_API.Models.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahoy_Hotel_API.Models.Hotel", "Hotel")
                        .WithMany("Facilities")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.HotelImage", b =>
                {
                    b.HasOne("Ahoy_Hotel_API.Models.Hotel", "Hotel")
                        .WithMany("Images")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Review", b =>
                {
                    b.HasOne("Ahoy_Hotel_API.Models.Guest", "Guest")
                        .WithMany("Reviews")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahoy_Hotel_API.Models.Hotel", "Hotel")
                        .WithMany("Reviews")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Room", b =>
                {
                    b.HasOne("Ahoy_Hotel_API.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Guest", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Ahoy_Hotel_API.Models.Hotel", b =>
                {
                    b.Navigation("Facilities");

                    b.Navigation("Images");

                    b.Navigation("Reviews");

                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}