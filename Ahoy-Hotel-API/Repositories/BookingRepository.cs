using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using Microsoft.EntityFrameworkCore;
using O.AlMamoon.Mobile.APP.API.Data;

namespace Ahoy_Hotel_API.Repositories;

public class BookingRepository : IBookingRepository
{
    private readonly DataContext _context;
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public BookingRepository(DataContext context, 
                             IConfiguration config, 
                             IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _config = config;
        _httpContextAccessor = httpContextAccessor;
    }

    public Task<Booking> GetReservation(int id)
    {
        return _context.Bookings
                        .Include(b => b.Room)
                        .Include(b => b.Guest)
                        .SingleOrDefaultAsync(b => b.Id == id);
    }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    public async Task<Booking> Reserve(Booking booking)
    {
        await _context.Bookings.AddAsync(booking);

        return booking;
    }

    public async Task<Booking> UpdateReservation(Booking booking)
    {
        _context.Entry(booking).State = EntityState.Modified;
        return await Task.Run(() => booking);
    }
}
