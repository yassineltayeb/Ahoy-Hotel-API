using Ahoy_Hotel_API.Contracts.HotelImage;
using Ahoy_Hotel_API.Models;
using AutoMapper;

namespace Ahoy_Hotel_API.Helpers.Mapper;

/* -------------------------------------------------------------------------- */
/*                             Hotel Image Profile                            */
/* -------------------------------------------------------------------------- */

public class HotelImageProfile : Profile
{
    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public HotelImageProfile()
    {
        CreateMap<HotelImage, HotelImageListDto>()
            .ForMember(dest => dest.Url, m => m.MapFrom(src => src.Url))
            .ReverseMap();
    }
}
