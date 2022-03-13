using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using Microsoft.EntityFrameworkCore;
using O.AlMamoon.Mobile.APP.API.Data;

namespace Ahoy_Hotel_API.Repositories;

/* -------------------------------------------------------------------------- */
/*                               Room Repository                              */
/* -------------------------------------------------------------------------- */

public class RoomRepository : IRoomRepository
{
    /* -------------------------------------------------------------------------- */
    /*                                  Variables                                 */
    /* -------------------------------------------------------------------------- */

    private readonly DataContext _context;
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public RoomRepository(DataContext context,
                          IConfiguration config,
                          IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _config = config;
        _httpContextAccessor = httpContextAccessor;
    }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ----------------------------- Get Room By ID ----------------------------- */
    public async Task<Room> GetRoomByID(int id)
    {
        return await _context.Rooms.SingleOrDefaultAsync(r => r.RoomNo == id);
    }
}
