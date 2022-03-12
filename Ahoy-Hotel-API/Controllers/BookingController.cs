using Ahoy_Hotel_API.Contracts.Booking;
using Ahoy_Hotel_API.Helpers.Common;
using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ahoy_Hotel_API.Controllers;

/* -------------------------------------------------------------------------- */
/*                             Booking Controller                             */
/* -------------------------------------------------------------------------- */

[Route("api/booking")]
[Authorize]
[ApiController]
public class BookingController : ControllerBase
{
    /* -------------------------------------------------------------------------- */
    /*                                  Variables                                 */
    /* -------------------------------------------------------------------------- */

    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public BookingController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* --------------------------------- Reserve -------------------------------- */
    [HttpPost]
    public async Task<IActionResult> Reserve(BookingReserveDto bookingReserveDto)
    {

        var bookingToAdd = _mapper.Map<Booking>(bookingReserveDto);

        var room = await _unitOfWork.Rooms.GetRoomByID(bookingToAdd.Room.RoomNo);

        if (room == null)
        {
            return NotFound(new RequestDetails
            {
                Data = new List<object>(),
                Status = false,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Room not found"
            });
        }

        var guest = await _unitOfWork.Guests.GetCurrentGuest();
        bookingToAdd.Guest = guest;
        bookingToAdd.Room = room;

        await _unitOfWork.Bookings.Reserve(bookingToAdd);
        await _unitOfWork.Complete();

        var bookingToReturn = _mapper.Map<BookingListDto>(bookingToAdd);

        return Ok(new RequestDetails
        {
            Data = bookingToReturn,
            Status = false,
            StatusCode = StatusCodes.Status200OK,
            Message = "Reserved successfully"
        });
    }

    /* ----------------------------- Update Booking ----------------------------- */
    [HttpPut]
    public async Task<IActionResult> UpdateBooking([FromBody] BookingUpdateDto bookingUpdateDto)
    {
        var booking = await _unitOfWork.Bookings.GetReservation(bookingUpdateDto.Id);

        if (booking == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Booking Not Found"
            });

        var bookingToUpdate = _mapper.Map<Booking>(bookingUpdateDto);

        booking.UpdatedOn = DateTime.Now;
        await _unitOfWork.Bookings.UpdateReservation(bookingToUpdate);
        await _unitOfWork.Complete();

        var bookingToReturn = _mapper.Map<BookingListDto>(bookingToUpdate);

        return Ok(new RequestDetails
        {
            Data = bookingToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Update
        });
    }

    /* ----------------------------- Delete Booking ----------------------------- */
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBooking(int id)
    {
        var booking = await _unitOfWork.Bookings.GetReservation(id);

        if (booking == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Booking Not Found"
            });

        booking.IsDeleted = true;
        booking.UpdatedOn = DateTime.Now;
        await _unitOfWork.Bookings.UpdateReservation(booking);
        await _unitOfWork.Complete();

        var bookingToReturn = _mapper.Map<BookingListDto>(booking);

        return Ok(new RequestDetails
        {
            Data = bookingToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Delete
        });
    }
}
