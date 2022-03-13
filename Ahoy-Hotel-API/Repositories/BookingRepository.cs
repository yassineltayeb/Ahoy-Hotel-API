using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using Microsoft.EntityFrameworkCore;
using O.AlMamoon.Mobile.APP.API.Data;

namespace Ahoy_Hotel_API.Repositories;

/* -------------------------------------------------------------------------- */
/*                             Booking Repository                             */
/* -------------------------------------------------------------------------- */

public class BookingRepository : IBookingRepository
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

    public BookingRepository(DataContext context,
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

    /* ----------------------------- Get Reservation ---------------------------- */
    public Task<Booking> GetReservation(int id)
    {
        return _context.Bookings
                        .Include(b => b.Room)
                        .Include(b => b.Guest)
                        .SingleOrDefaultAsync(b => b.Id == id);
    }

    /* --------------------------------- Reserve -------------------------------- */
    public async Task<Booking> Reserve(Booking booking)
    {
        await _context.Bookings.AddAsync(booking);

        return booking;
    }

    /* --------------------------- Update Reservation --------------------------- */
    public async Task<Booking> UpdateReservation(Booking booking)
    {
        _context.Entry(booking).State = EntityState.Modified;
        return await Task.Run(() => booking);
    }
}
