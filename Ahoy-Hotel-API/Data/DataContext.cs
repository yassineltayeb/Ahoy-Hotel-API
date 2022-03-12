using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Ahoy_Hotel_API.Models;

namespace O.AlMamoon.Mobile.APP.API.Data;

/* -------------------------------------------------------------------------- */
/*                                Data Context                                */
/* -------------------------------------------------------------------------- */

public class DataContext : DbContext
{
    /* -------------------------------------------------------------------------- */
    /*                                Constructors                                */
    /* -------------------------------------------------------------------------- */

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    /* -------------------------------------------------------------------------- */
    /*                                  Data Sets                                 */
    /* -------------------------------------------------------------------------- */

    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Facility> Facilities { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<HotelFacility> HotelFacilities { get; set; }
    public DbSet<HotelImage> HotelImages { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Room> Rooms { get; set; }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ---------------------------- On Model Creating --------------------------- */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        /* -------------------------------------------------------------------------- */
        /*                                Seed Database                               */
        /* -------------------------------------------------------------------------- */

        /* -------------------------------- Facility -------------------------------- */
        modelBuilder.Entity<Facility>().HasData(new Facility
        {
            Id = 1,
            Name = "Breakfast",
            IconURL = "https://www.icons.com/breakfast",
        });

        modelBuilder.Entity<Facility>().HasData(new Facility
        {
            Id = 2,
            Name = "Wifi",
            IconURL = "https://www.icons.com/wifi",
        });

        modelBuilder.Entity<Facility>().HasData(new Facility
        {
            Id = 3,
            Name = "Parking",
            IconURL = "https://www.icons.com/parking",
        });

        modelBuilder.Entity<Facility>().HasData(new Facility
        {
            Id = 4,
            Name = "Spa",
            IconURL = "https://www.icons.com/Spa",
        });

        /* ---------------------------------- Guest --------------------------------- */
        modelBuilder.Entity<Guest>().HasData(new Guest
        {
            Id = 1,
            FullName = "Guest User",
            Email = "yassineltayeb@live.com",
            Password = BCrypt.Net.BCrypt.HashPassword("123456"),
        });

        modelBuilder.Entity<Hotel>().HasData(new Hotel
        {
            Id = 1,
            Name = "Raffles Dubai",
            Address = "Sheikh Rashid Road, Wafi Mall, Bur Dubai, Dubai, United Arab Emirates",
            Location = "https://www.google.com/maps/dir/25.267754,55.3475338/Raffles+Dubai/@25.247935,55.2678204,12z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x3e5f5d4a2139ede3:0x6d83d44701a241ab!2m2!1d55.3203503!2d25.227917",
            Description = "Inspired by the great pyramids of Egypt, Raffles Dubai is a stunning landmark in Dubai�s skyline. This award-winning hotel features an outdoor pool, an extensive spa and free in-room WiFi.",
            Email = "guests@rafflesdubai.com",
            PhoneNumber = "05555555"
        });

        /* ----------------------------- Hotel Facility ----------------------------- */
        modelBuilder.Entity<HotelFacility>().HasData(new HotelFacility
        {
            Id = 1,
            FacilityId = 1,
            HotelId = 1
        });

        modelBuilder.Entity<HotelFacility>().HasData(new HotelFacility
        {
            Id = 2,
            FacilityId = 2,
            HotelId = 1
        });

        modelBuilder.Entity<HotelFacility>().HasData(new HotelFacility
        {
            Id = 3,
            FacilityId = 3,
            HotelId = 1
        });

        modelBuilder.Entity<HotelFacility>().HasData(new HotelFacility
        {
            Id = 4,
            FacilityId = 4,
            HotelId = 1
        });

        /* ------------------------------- Hotel Image ------------------------------ */
        modelBuilder.Entity<HotelImage>().HasData(new HotelImage
        {
            Id = 1,
            Url = "https://www.images.com/image1",
            HotelId = 1
        });

        modelBuilder.Entity<HotelImage>().HasData(new HotelImage
        {
            Id = 2,
            Url = "https://www.images.com/image2",
            HotelId = 1
        });
        modelBuilder.Entity<HotelImage>().HasData(new HotelImage
        {
            Id = 3,
            Url = "https://www.images.com/image3",
            HotelId = 1
        });

        /* --------------------------------- Review --------------------------------- */
        modelBuilder.Entity<Review>().HasData(new Review()
        {
            Id = 1,
            Rating = 5,
            Description = "The entire experience from check-in to check out. Great staffs, room, decoration, food, facilities. Also, very nice attentions have been offered for our special occasion :)",
            HotelId = 1,
            GuestId = 1
        });

        /* ---------------------------------- Room ---------------------------------- */
        modelBuilder.Entity<Room>().HasData(new Room()
        {
            Id = 1,
            RoomNo = 101,
            NoOfGuests = 2,
            Price = 680,
            HotelId = 1
        });

        modelBuilder.Entity<Room>().HasData(new Room()
        {
            Id = 2,
            RoomNo = 102,
            NoOfGuests = 2,
            Price = 680,
            HotelId = 1
        });

        modelBuilder.Entity<Room>().HasData(new Room()
        {
            Id = 3,
            RoomNo = 103,
            NoOfGuests = 2,
            Price = 680,
            HotelId = 1
        });
    }
}
