using Ahoy_Hotel_API.Contracts.Guest;
using Ahoy_Hotel_API.Helpers.Pagination;
using Ahoy_Hotel_API.Models;

namespace Ahoy_Hotel_API.Interfaces;

/* -------------------------------------------------------------------------- */
/*                              IGuest Repository                             */
/* -------------------------------------------------------------------------- */

public interface IGuestRepository
{
    Task<Guest> GetGuestByID(int id);
    Task<Guest> GetUserByEmail(string email);
    Task<Guest> Register(Guest guest);
    Task<string> Login(GuestLoginDto loginDto);
    Task<Guest> GetCurrentGuest();
    Task<Guest> UpdateGuest(Guest guest);
    Task<PagedList<Booking>> GetGuestBookings(GuestFilterDto guestFilterDto);
}
