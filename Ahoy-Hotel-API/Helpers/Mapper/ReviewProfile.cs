using Ahoy_Hotel_API.Contracts.Review;
using Ahoy_Hotel_API.Models;
using AutoMapper;

namespace Ahoy_Hotel_API.Helpers.Mapper;

/* -------------------------------------------------------------------------- */
/*                               Review Profile                               */
/* -------------------------------------------------------------------------- */

public class ReviewProfile : Profile
{
    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */
    public ReviewProfile()
    {
        CreateMap<Review, ReviewListDto>()
            .ForMember(dest => dest.Guest, m => m.MapFrom(src => src.Guest.FullName))
            .ReverseMap();

        CreateMap<Review, ReivewAddDto>().ReverseMap();
    }
}
