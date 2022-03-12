using Ahoy_Hotel_API.Contracts.Guest;
using Ahoy_Hotel_API.Models;
using AutoMapper;

namespace Ahoy_Hotel_API.Helpers.Mapper;

/* -------------------------------------------------------------------------- */
/*                                Guest Profile                               */
/* -------------------------------------------------------------------------- */

public class GuestProfile : Profile
{
    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public GuestProfile()
    {
        CreateMap<Guest, GuestLoginDto>().ReverseMap();
        CreateMap<Guest, GuestRegisterDto>().ReverseMap();
        CreateMap<Guest, GuestListDto>().ReverseMap();
    }
}
