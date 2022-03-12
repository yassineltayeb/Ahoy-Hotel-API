using Ahoy_Hotel_API.Helpers.Mapper;
using Ahoy_Hotel_API.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;

namespace Ahoy_Hotel_Test;
public static class MockServices
{
    public static IMapper GetMockedMapper<I>()
    {
        MapperConfiguration mappingConfig = new(mc =>
        {
            mc.AddProfile(new BookingProfile());
            mc.AddProfile(new GuestProfile());
            mc.AddProfile(new HotelProfile());
            mc.AddProfile(new ReviewProfile());
            mc.AddProfile(new RoomProfile());
        });
        return mappingConfig.CreateMapper();
    }
    public static ILogger<T> GetMockedLoger<T>() => new Mock<ILogger<T>>().Object;

}
