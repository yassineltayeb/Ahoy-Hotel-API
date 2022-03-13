using Ahoy_Hotel_API.Contracts.Room;
using Ahoy_Hotel_API.Models;
using AutoMapper;

namespace Ahoy_Hotel_API.Helpers.Mapper;

/* -------------------------------------------------------------------------- */
/*                                Room Profile                                */
/* -------------------------------------------------------------------------- */

public class RoomProfile : Profile
{
    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public RoomProfile()
    {
        CreateMap<Room, RoomListDto>().ReverseMap();
        CreateMap<Room, RoomAddDto>().ReverseMap();
    }
}
