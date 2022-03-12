using Ahoy_Hotel_API.Contracts.Guest;
using Ahoy_Hotel_API.Helpers.Pagination;
using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using O.AlMamoon.Mobile.APP.API.Data;
using O.AlMamoon.Mobile.APP.API.Exceptions;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ahoy_Hotel_API.Repositories;

/* -------------------------------------------------------------------------- */
/*                              Guest Repository                              */
/* -------------------------------------------------------------------------- */

public class GuestRepository : IGuestRepository
{
    private readonly DataContext _context;
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public GuestRepository(DataContext context,
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

    public async Task<Guest> GetGuestByID(int id)
    {
        return await _context.Guests.SingleOrDefaultAsync(u => u.Id == id);
    }

    /* ---------------------------- Get User By Email --------------------------- */
    public async Task<Guest> GetUserByEmail(string email)
    {
        return await _context.Guests
                                .AsNoTracking()
                                .SingleOrDefaultAsync(u => u.Email == email);
    }

    /* -------------------------------- Register -------------------------------- */
    public async Task<Guest> Register(Guest guest)
    {
        await _context.Guests.AddAsync(guest);

        return guest;
    }

    /* ---------------------------------- Login --------------------------------- */
    public async Task<string> Login(GuestLoginDto guestLoginDto)
    {
        var username = guestLoginDto.Email.ToLower();

        var user = await GetUserByEmail(username);

        if (user == null || !(BCrypt.Net.BCrypt.Verify(guestLoginDto.Password, user.Password))) throw new UnauthorizedActionException("Incorrect username or password");

        var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.FullName),
            };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Secret").Value));

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddMonths(1),
            SigningCredentials = credentials
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }

    public async Task<Guest> GetCurrentGuest()
    {
        var guestID = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

        return await GetGuestByID(guestID);
    }

    public async Task<Guest> UpdateGuest(Guest guest)
    {
        _context.Entry(guest).State = EntityState.Modified;
        return await Task.Run(() => guest);
    }

    public async Task<PagedList<Booking>> GetGuestBookings(GuestFilterDto guestFilterDto)
    {
        var bookings = _context.Bookings
                               .Include(h => h.Room)
                               .Include(h => h.Guest)
                               .OrderBy(h => h.Id)
                               .AsQueryable();

        return PagedList<Booking>.ToPagedList(bookings.ToList(), guestFilterDto.PageNumber, guestFilterDto.PageSize);
    }
}
