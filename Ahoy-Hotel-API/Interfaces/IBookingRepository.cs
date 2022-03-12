using Ahoy_Hotel_API.Models;

namespace Ahoy_Hotel_API.Interfaces;

/* -------------------------------------------------------------------------- */
/*                             IBooking Repository                            */
/* -------------------------------------------------------------------------- */

public interface IBookingRepository
{
    Task<Booking> Reserve(Booking booking);
    Task<Booking> UpdateReservation(Booking booking);
    Task<Booking> GetReservation(int id);
}
