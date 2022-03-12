using Ahoy_Hotel_API.Helpers.Pagination;
using Ahoy_Hotel_API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahoy_Hotel_Test;
public static class HotelData
{
    public static async Task<PagedList<Hotel>> MockHotelSamples()
    {
        List<Hotel> hotels = new()
        {
            new Hotel()
            {
                Name = "Hotel2",
                PhoneNumber = "555555",
                Email = "email@gmail.com",
                Address = "Dubai",
                Description = "good hotel",
            },
            new Hotel()
            {
                Name = "Hotel",
                PhoneNumber = "555555",
                Email = "m@gmail.com",
                Address = "address",
                Description = " hotel",
            }
        };
        return await Task.FromResult(PagedList<Hotel>.ToPagedList(hotels, 1, 10));
    }


}
