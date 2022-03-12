using O.AlMamoon.Mobile.APP.API.Data;

namespace Ahoy_Hotel_API.Interfaces;

/* -------------------------------------------------------------------------- */
/*                                 IUnitOfWork                                */
/* -------------------------------------------------------------------------- */

public interface IUnitOfWork
{
    /* -------------------------------------------------------------------------- */
    /*                                  Variables                                 */
    /* -------------------------------------------------------------------------- */

    DataContext _context { get; }

    /* -------------------------------------------------------------------------- */
    /*                                Repositories                                */
    /* -------------------------------------------------------------------------- */

    IGuestRepository Guests { get; }
    IBookingRepository Bookings { get; }
    IRoomRepository Rooms { get; }
    IHotelRepository Hotels { get; }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    Task<bool> Complete();
    void BeginTransaction();
    Task Commit();
    void Dispose();
    void Rollback();

}
