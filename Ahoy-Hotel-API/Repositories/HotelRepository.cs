using Ahoy_Hotel_API.Contracts.Hotel;
using Ahoy_Hotel_API.Extensions;
using Ahoy_Hotel_API.Helpers.Pagination;
using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using Microsoft.EntityFrameworkCore;
using O.AlMamoon.Mobile.APP.API.Data;
using System.Linq.Expressions;

namespace Ahoy_Hotel_API.Repositories;

/* -------------------------------------------------------------------------- */
/*                              Hotel Repository                              */
/* -------------------------------------------------------------------------- */

public class HotelRepository : IHotelRepository
{
    /* -------------------------------------------------------------------------- */
    /*                                  Variables                                 */
    /* -------------------------------------------------------------------------- */

    private readonly DataContext _context;
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public HotelRepository(DataContext context,
                           IConfiguration config,
                           IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _config = config;
        _httpContextAccessor = httpContextAccessor;
    }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* -------------------------------- Add Hotel ------------------------------- */
    public async Task<Hotel> AddHotel(Hotel hotel)
    {
        await _context.Hotels.AddAsync(hotel);
        return hotel;
    }

    /* --------------------------- Add Hotel Facility --------------------------- */
    public async Task<HotelFacility> AddHotelFacility(HotelFacility facility)
    {
        await _context.HotelFacilities.AddRangeAsync(facility);

        return facility;
    }

    /* ---------------------------- Add Hotel Review ---------------------------- */
    public async Task<Review> AddHotelReview(Review review)
    {
        await _context.Reviews.AddRangeAsync(review);

        return review;
    }

    /* ----------------------------- Add Hotel Room ----------------------------- */
    public async Task<Room> AddHotelRoom(Room room)
    {
        await _context.Rooms.AddRangeAsync(room);

        return room;
    }

    /* ----------------------------- Get Hotel By Id ---------------------------- */
    public async Task<Hotel> GetHotelById(int id)
    {
        return await _context.Hotels
                                .Include(h => h.Facilities)
                                .Include(h => h.Images)
                                .Include(h => h.Reviews)
                                .Include(h => h.Rooms)
                                .SingleOrDefaultAsync(h => h.Id == id);
    }

    /* ------------------------------- Get Hotels ------------------------------- */
    public async Task<PagedList<Hotel>> GetHotels(HotelFilterDto hotelFilterDto)
    {
        var hotels = _context.Hotels
                                .Include(h => h.Facilities)
                                .Include(h => h.Images)
                                .Include(h => h.Reviews)
                                .Include(h => h.Rooms)
                                .OrderBy(h => h.Id)
                                .AsQueryable();

        /* -------------------------------- Filtering ------------------------------- */
        hotels = hotels.ApplyFiltering(hotelFilterDto);

        /* --------------------------------- Sorting -------------------------------- */
        var columnsMap = GetHotelsSortingParameters();
        hotels = hotels.ApplyOrdering(hotelFilterDto, columnsMap);

        /* ------------------------------- Pagination ------------------------------- */
        return PagedList<Hotel>.ToPagedList(hotels.ToList(), hotelFilterDto.PageNumber, hotelFilterDto.PageSize);
    }

    /* ------------------------------ Update Hotel ------------------------------ */
    public async Task<Hotel> UpdateHotel(Hotel hotel)
    {
        _context.Entry(hotel).State = EntityState.Modified;
        return await Task.Run(() => hotel);
    }

    /* ---------------------- Get Hotels Sorting Parameters --------------------- */
    private Dictionary<string, Expression<Func<Hotel, object>>> GetHotelsSortingParameters()
    {
        return new Dictionary<string, Expression<Func<Hotel, object>>>()
        {
            ["id"] = p => p.Id,
            ["name"] = p => p.Name
        };
    }
}
