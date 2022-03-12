using Ahoy_Hotel_API.Models;

namespace Ahoy_Hotel_API.Contracts.Room;

/* -------------------------------------------------------------------------- */
/*                                Room List Dto                               */
/* -------------------------------------------------------------------------- */

public class RoomListDto : BaseEntity
{
    public int RoomNo { get; set; }
    public int NoOfGuests { get; set; }
    public double Price { get; set; }
}
