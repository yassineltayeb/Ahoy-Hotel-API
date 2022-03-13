using Ahoy_Hotel_API.Contracts.Hotel;
using Ahoy_Hotel_API.Helpers.Pagination;
using Ahoy_Hotel_API.Models;

namespace Ahoy_Hotel_API.Interfaces;

/* -------------------------------------------------------------------------- */
/*                              IHotel Repository                             */
/* -------------------------------------------------------------------------- */

public interface IHotelRepository
{
    Task<PagedList<Hotel>> GetHotels(HotelFilterDto hotelFilterDto);
    Task<Hotel> GetHotelById(int id);
    Task<Hotel> AddHotel(Hotel hotel);
    Task<Hotel> UpdateHotel(Hotel hotel);
    Task<Review> AddHotelReview(Review review);
    Task<HotelFacility> AddHotelFacility(HotelFacility facility);
    Task<Room> AddHotelRoom(Room room);
}
