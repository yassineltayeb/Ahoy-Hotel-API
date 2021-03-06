// <auto-generated />
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
    [Migration("20220312091249_AddNewColumnsToBokking")]
    partial class AddNewColumnsToBokking
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
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9848),
                            IconURL = "https://www.icons.com/breakfast",
                            IsDeleted = false,
                            Name = "Breakfast",
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9869)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9949),
                            IconURL = "https://www.icons.com/breakfast",
                            IsDeleted = false,
                            Name = "Wifi",
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9951)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9990),
                            IconURL = "https://www.icons.com/breakfast",
                            IsDeleted = false,
                            Name = "Parking",
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9998)
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(35),
                            IconURL = "https://www.icons.com/breakfast",
                            IsDeleted = false,
                            Name = "Spa",
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(37)
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
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(72),
                            Email = "yassineltayeb@live.com",
                            FullName = "Guest User",
                            IsDeleted = false,
                            Password = "$2a$11$j1ooCGFULW8WyHDuqTcBJOT8ne18aqKZ9QG/J/gyPhqRJZA/.Hlpq",
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(74)
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

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sheikh Rashid Road, Wafi Mall, Bur Dubai, Dubai, United Arab Emirates",
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(809),
                            Description = "Inspired by the great pyramids of Egypt, Raffles Dubai is a stunning landmark in Dubai�s skyline. This award-winning hotel features an outdoor pool, an extensive spa and free in-room WiFi.",
                            Email = "guests@rafflesdubai.com",
                            IsDeleted = false,
                            Location = "https://www.google.com/maps/dir/25.267754,55.3475338/Raffles+Dubai/@25.247935,55.2678204,12z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x3e5f5d4a2139ede3:0x6d83d44701a241ab!2m2!1d55.3203503!2d25.227917",
                            Name = "Raffles Dubai",
                            PhoneNumber = "05555555",
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(823)
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
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(860),
                            FacilityId = 1,
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(861)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(870),
                            FacilityId = 2,
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(870)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(878),
                            FacilityId = 3,
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(878)
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(885),
                            FacilityId = 4,
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(886)
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
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(901),
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(901),
                            Url = "https://www.images.com/image1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(910),
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(911),
                            Url = "https://www.images.com/image2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(933),
                            HotelId = 1,
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(934),
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
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(948),
                            Description = "The entire experience from check-in to check out. Great staffs, room, decoration, food, facilities. Also, very nice attentions have been offered for our special occasion :)",
                            GuestId = 1,
                            HotelId = 1,
                            IsDeleted = false,
                            Rating = 5,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(949)
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
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(963),
                            HotelId = 1,
                            IsDeleted = false,
                            NoOfGuests = 2,
                            Price = 680.0,
                            RoomNo = 101,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(963)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(972),
                            HotelId = 1,
                            IsDeleted = false,
                            NoOfGuests = 2,
                            Price = 680.0,
                            RoomNo = 102,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(973)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(991),
                            HotelId = 1,
                            IsDeleted = false,
                            NoOfGuests = 2,
                            Price = 680.0,
                            RoomNo = 103,
                            UpdatedOn = new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(992)
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
