using Ahoy_Hotel_API.Contracts.Hotel;
using Ahoy_Hotel_API.Extensions;
using Ahoy_Hotel_API.Helpers.Pagination;
using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using Microsoft.EntityFrameworkCore;
using O.AlMamoon.Mobile.APP.API.Data;
using System.Linq.Expressions;

namespace Ahoy_Hotel_API.Repositories;

public class HotelRepository : IHotelRepository
{
    private readonly DataContext _context;
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public HotelRepository(DataContext context, 
                           IConfiguration config, 
                           IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _config = config;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<Hotel> AddHotel(Hotel hotel)
    {
        await _context.Hotels.AddAsync(hotel);
        return hotel;
    }

    public async Task<Hotel> GetHotelById(int id)
    {
        return await _context.Hotels
                                .Include(h => h.Facilities)
                                .Include(h => h.Images)
                                .Include(h => h.Reviews)
                                .Include(h => h.Rooms)
                                .SingleOrDefaultAsync(h => h.Id == id);
    }

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

        return  PagedList<Hotel>.ToPagedList(hotels.ToList(), hotelFilterDto.PageNumber, hotelFilterDto.PageSize);
    }

    public async Task<Hotel> UpdateHotel(Hotel hotel)
    {
        _context.Entry(hotel).State = EntityState.Modified;
        return await Task.Run(() => hotel);
    }

    private Dictionary<string, Expression<Func<Hotel, object>>> GetHotelsSortingParameters()
    {
        return new Dictionary<string, Expression<Func<Hotel, object>>>()
        {
            ["id"] = p => p.Id,
            ["name"] = p => p.Name
        };
    }
}
