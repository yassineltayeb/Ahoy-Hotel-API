using Ahoy_Hotel_API.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using O.AlMamoon.Mobile.APP.API.Data;

namespace Ahoy_Hotel_API.Repositories;

/* -------------------------------------------------------------------------- */
/*                                 UnitOfWork                                 */
/* -------------------------------------------------------------------------- */

public class UnitOfWork : IUnitOfWork
{
    /* -------------------------------------------------------------------------- */
    /*                                  Variables                                 */
    /* -------------------------------------------------------------------------- */

    public DataContext _context { get; }
    public IConfiguration Configuration { get; }
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private IDbContextTransaction _transaction;

    private IGuestRepository _guestRepository;
    private IBookingRepository _bookingRepository;
    private IRoomRepository _roomRepository;
    private IHotelRepository _hotelRepository;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public UnitOfWork(DataContext context)
    {
        _context = context;
        //_context.ChangeTracker.CascadeDeleteTiming = CascadeTiming.OnSaveChanges;
        //_context.ChangeTracker.DeleteOrphansTiming = CascadeTiming.OnSaveChanges;
        _config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();
        _httpContextAccessor = new HttpContextAccessor();
    }

    public IGuestRepository Guests
    {
        get
        {
            if (_guestRepository == null)
            {
                _guestRepository = new GuestRepository(_context, _config, _httpContextAccessor);
            }

            return _guestRepository;
        }
    }

    public IBookingRepository Bookings
    {
        get
        {
            if (_bookingRepository == null)
            {
                _bookingRepository = new BookingRepository(_context, _config, _httpContextAccessor);
            }

            return _bookingRepository;
        }
    }

    public IRoomRepository Rooms
    {
        get
        {
            if (_roomRepository == null)
            {
                _roomRepository = new RoomRepository(_context, _config, _httpContextAccessor);
            }

            return _roomRepository;
        }
    }

    public IHotelRepository Hotels
    {
        get
        {
            if (_hotelRepository == null)
            {
                _hotelRepository = new HotelRepository(_context, _config, _httpContextAccessor);
            }

            return _hotelRepository;
        }
    }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* -------------------------------- Complete -------------------------------- */
    public async Task<bool> Complete()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    /* ------------------------------- Transaction ------------------------------ */
    public async void BeginTransaction()
    {
        _transaction = await _context.Database.BeginTransactionAsync();
    }

    /* --------------------------------- Commit --------------------------------- */
    public async Task Commit()
    {
        //await _context.Database.CommitTransactionAsync();
        await _transaction.CommitAsync();

    }

    /* --------------------------------- Dispose -------------------------------- */
    public void Dispose()
    {
        _context.Dispose();
    }

    /* -------------------------------- Roll back ------------------------------- */
    public async void Rollback()
    {
        await _transaction.RollbackAsync();
    }
}
