using Ahoy_Hotel_API.Contracts.Booking;
using Ahoy_Hotel_API.Contracts.Guest;
using Ahoy_Hotel_API.Helpers.Common;
using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ahoy_Hotel_API.Controllers;

/* -------------------------------------------------------------------------- */
/*                               Auth Controller                              */
/* -------------------------------------------------------------------------- */

[Route("api/guest")]
[Authorize]
[ApiController]
public class GuestController : ControllerBase
{
    /* -------------------------------------------------------------------------- */
    /*                                  Variables                                 */
    /* -------------------------------------------------------------------------- */

    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public GuestController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* -------------------------------- Register -------------------------------- */
    [AllowAnonymous]
    [HttpPost("register")]
    public async Task<IActionResult> Register(GuestRegisterDto guestRegisterDto)
    {
        var guest = await _unitOfWork.Guests.GetUserByEmail(guestRegisterDto.Email.ToLower());

        if (guest != null)
        {
            return BadRequest(new RequestDetails
            {
                Data = new List<object>(),
                Status = false,
                StatusCode = StatusCodes.Status400BadRequest,
                Message = "Guest already exist"
            });
        }

        guestRegisterDto.Password = BCrypt.Net.BCrypt.HashPassword(guestRegisterDto.Password);

        var guestToAdd = _mapper.Map<Guest>(guestRegisterDto);

        await _unitOfWork.Guests.Register(guestToAdd);
        await _unitOfWork.Complete();

        var guestToReturn = _mapper.Map<GuestListDto>(guestToAdd);

        return Ok(new RequestDetails
        {
            Data = guestToReturn,
            Status = false,
            StatusCode = StatusCodes.Status200OK,
            Message = "Registered successfully"
        });
    }

    /* ---------------------------------- Login --------------------------------- */
    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login(GuestLoginDto guestLoginDto)
    {
        var userToken = await _unitOfWork.Guests.Login(guestLoginDto);

        if (userToken == null)
            return Unauthorized(new RequestDetails
            {
                Data = new List<object>(),
                Status = false,
                StatusCode = StatusCodes.Status401Unauthorized,
                Message = "Unauthorized"
            });

        var user = await _unitOfWork.Guests.GetUserByEmail(guestLoginDto.Email.ToLower());

        var data = new
        {
            Id = user.Id,
            fullName = user.FullName,
            email = user.Email,
            token = userToken
        };

        return Ok(new RequestDetails
        {
            Data = data,
            Status = false,
            StatusCode = StatusCodes.Status200OK,
            Message = "Logged in successfully"
        });
    }

    /* ------------------------------ Update Guest ------------------------------ */
    [HttpPut]
    public async Task<IActionResult> UpdateGuest([FromBody] GuestUpdateDto guestUpdateDto)
    {
        var guest = await _unitOfWork.Guests.GetGuestByID(guestUpdateDto.Id);

        if (guest == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Guest Not Found"
            });

        var guestToUpdate = _mapper.Map<Guest>(guestUpdateDto);

        guest.UpdatedOn = DateTime.Now;
        await _unitOfWork.Guests.UpdateGuest(guestToUpdate);
        await _unitOfWork.Complete();

        var guestToReturn = _mapper.Map<GuestListDto>(guestToUpdate);

        return Ok(new RequestDetails
        {
            Data = guestToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Update
        });
    }

    /* ------------------------------ Delete Guest ------------------------------ */
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGuest(int id)
    {
        var guest = await _unitOfWork.Guests.GetGuestByID(id);

        if (guest == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Guest Not Found"
            });

        guest.IsDeleted = true;
        guest.UpdatedOn = DateTime.Now;
        await _unitOfWork.Guests.UpdateGuest(guest);
        await _unitOfWork.Complete();

        var guestToReturn = _mapper.Map<GuestListDto>(guest);

        return Ok(new RequestDetails
        {
            Data = guestToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Delete
        });
    }

    /* --------------------------- Get Guest Bookings --------------------------- */
    [HttpGet("bookings")]
    public async Task<IActionResult> GetGuestBookings([FromQuery] GuestFilterDto guestFilterDto)
    {
        var bookings = await _unitOfWork.Guests.GetGuestBookings(guestFilterDto);

        var metadata = new
        {
            totalCount = bookings.TotalCount,
            pageSize = bookings.PageSize,
            currentPage = bookings.CurrentPage,
            totalPages = bookings.TotalPages,
            hasNext = bookings.HasNext,
            hasPrevious = bookings.HasPrevious
        };

        Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

        var bookingsToReturn = _mapper.Map<IList<BookingListDto>>(bookings);

        return Ok(new RequestDetails
        {
            Data = bookingsToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Success
        });
    }
}
