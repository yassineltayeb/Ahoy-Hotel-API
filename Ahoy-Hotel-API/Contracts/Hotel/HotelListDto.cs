using Ahoy_Hotel_API.Contracts.HotelFacility;
using Ahoy_Hotel_API.Contracts.HotelImage;
using Ahoy_Hotel_API.Contracts.Review;
using Ahoy_Hotel_API.Contracts.Room;
using Ahoy_Hotel_API.Models;

namespace Ahoy_Hotel_API.Contracts.Hotel;

/* -------------------------------------------------------------------------- */
/*                               Hotel List Dto                               */
/* -------------------------------------------------------------------------- */

public class HotelListDto : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<HotelFacilityListDto> Facilities { get; set; }
    public List<HotelImageListDto> Images { get; set; }
    public virtual List<ReviewListDto> Reviews { get; set; }
    public virtual List<RoomListDto> Rooms { get; set; }
}
