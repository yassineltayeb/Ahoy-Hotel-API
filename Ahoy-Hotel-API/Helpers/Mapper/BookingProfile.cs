using Ahoy_Hotel_API.Models;
using Ahoy_Hotel_API.Contracts.Booking;
using AutoMapper;

namespace Ahoy_Hotel_API.Helpers.Mapper;

/* -------------------------------------------------------------------------- */
/*                               Booking Profile                              */
/* -------------------------------------------------------------------------- */

public class BookingProfile : Profile
{
    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public BookingProfile()
    {
        CreateMap<Booking, BookingReserveDto>()
            .ForMember(dest => dest.RoomNo, m => m.MapFrom(src => src.Room.RoomNo))
            .ForMember(dest => dest.Guest, m => m.MapFrom(src => src.Guest.FullName))
            .ReverseMap();

        CreateMap<Booking, BookingListDto>()
            .ForMember(dest => dest.Room, m => m.MapFrom(src => src.Room.RoomNo))
            .ForMember(dest => dest.Guest, m => m.MapFrom(src => src.Guest.FullName))
            .ReverseMap();
    }
}
