using Ahoy_Hotel_API.Contracts.Hotel;
using Ahoy_Hotel_API.Models;
using AutoMapper;

namespace Ahoy_Hotel_API.Helpers.Mapper;

/* -------------------------------------------------------------------------- */
/*                                Hotel Profile                               */
/* -------------------------------------------------------------------------- */

public class HotelProfile : Profile
{

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public HotelProfile()
    {
        CreateMap<Hotel, HotelListDto>()
            .ReverseMap();
    }
}
