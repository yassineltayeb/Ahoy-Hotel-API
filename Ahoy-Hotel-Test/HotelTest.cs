using Ahoy_Hotel_API.Contracts.Hotel;
using Ahoy_Hotel_API.Controllers;
using Ahoy_Hotel_API.Helpers.Pagination;
using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using AutoMapper;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Ahoy_Hotel_Test;
public class HotelTest
{
    private readonly Mock<IUnitOfWork> MockContext;


    public HotelTest()
    {
        var hotelRepositoryMock = new Mock<IHotelRepository>();
        hotelRepositoryMock.Setup(m => m.GetHotels(new HotelFilterDto { })).Returns(HotelData.MockHotelSamples()).Verifiable();

        MockContext = new Mock<IUnitOfWork>();
        MockContext.Setup(m => m.Hotels).Returns(hotelRepositoryMock.Object);
    }



    [Fact]
    public async Task Can_Get_All_Hotels()
    {
        var hotelController = new HotelController(MockContext.Object, MockServices.GetMockedMapper<IMapper>());
        PagedList<Hotel>? GetHotels = await MockContext.Object.Hotels.GetHotels(new HotelFilterDto { });
        GetHotels = await HotelData.MockHotelSamples();
        Assert.NotNull(GetHotels);
        Assert.Equal(2, GetHotels.Count );
    }
}




