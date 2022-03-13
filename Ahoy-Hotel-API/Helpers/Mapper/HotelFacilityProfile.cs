using Ahoy_Hotel_API.Contracts.HotelFacility;
using Ahoy_Hotel_API.Models;
using AutoMapper;

namespace Ahoy_Hotel_API.Helpers.Mapper;

/* -------------------------------------------------------------------------- */
/*                           Hotel Facility Profile                           */
/* -------------------------------------------------------------------------- */

public class HotelFacilityProfile : Profile
{
    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public HotelFacilityProfile()
    {
        CreateMap<HotelFacility, HotelFacilityListDto>()
            .ForMember(dest => dest.Facility, m => m.MapFrom(src => src.Facility.Name))
            .ReverseMap();

        CreateMap<HotelFacility, HotelFacilityAddDto>().ReverseMap();
    }
}
