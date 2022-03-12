using Ahoy_Hotel_API.Models;

namespace Ahoy_Hotel_API.Interfaces;

/* -------------------------------------------------------------------------- */
/*                              IRoom Repository                              */
/* -------------------------------------------------------------------------- */

public interface IRoomRepository
{
    Task<Room> GetRoomByID(int id);
}
