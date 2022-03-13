using Ahoy_Hotel_API.Contracts.Hotel;
using Ahoy_Hotel_API.Contracts.HotelFacility;
using Ahoy_Hotel_API.Contracts.Review;
using Ahoy_Hotel_API.Contracts.Room;
using Ahoy_Hotel_API.Helpers.Common;
using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ahoy_Hotel_API.Controllers;

/* -------------------------------------------------------------------------- */
/*                              Hotel Controller                              */
/* -------------------------------------------------------------------------- */

[Route("api/hotels")]
[ApiController]
public class HotelController : ControllerBase
{

    /* -------------------------------------------------------------------------- */
    /*                                  Variables                                 */
    /* -------------------------------------------------------------------------- */

    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public HotelController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ------------------------------- Get Hotels ------------------------------- */
    [HttpGet]
    public async Task<IActionResult> GetHotels([FromQuery] HotelFilterDto hotelFilterDto)
    {
        var hotels = await _unitOfWork.Hotels.GetHotels(hotelFilterDto);

        var metadata = new
        {
            totalCount = hotels.TotalCount,
            pageSize = hotels.PageSize,
            currentPage = hotels.CurrentPage,
            totalPages = hotels.TotalPages,
            hasNext = hotels.HasNext,
            hasPrevious = hotels.HasPrevious
        };

        Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

        var hotelsToReturn = _mapper.Map<IList<HotelListDto>>(hotels);

        return Ok(new RequestDetails
        {
            Data = hotelsToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Success
        });
    }

    /* ----------------------------- Get Hotel By ID ---------------------------- */
    [HttpGet("{id}")]
    public async Task<IActionResult> GetHotelByID(int id)
    {
        var hotel = await _unitOfWork.Hotels.GetHotelById(id);

        var hotelToReturn = _mapper.Map<HotelListDto>(hotel);

        return Ok(new RequestDetails
        {
            Data = hotelToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Success
        });
    }

    /* -------------------------------- Add Hotel ------------------------------- */
    [HttpPost]
    public async Task<IActionResult> AddHotel(HotelAddDto hotelAddDto)
    {
        var hotelToAdd = _mapper.Map<Hotel>(hotelAddDto);

        await _unitOfWork.Hotels.AddHotel(hotelToAdd);
        await _unitOfWork.Complete();

        var hotelToReturn = _mapper.Map<HotelListDto>(hotelToAdd);

        return Ok(new RequestDetails
        {
            Data = hotelToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Success
        });
    }

    /* ------------------------------ Update Hotel ------------------------------ */
    [HttpPut]
    public async Task<IActionResult> UpdateHotel([FromBody] HotelUpdateDto hotelUpdateDto)
    {
        var hotel = await _unitOfWork.Hotels.GetHotelById(hotelUpdateDto.Id);

        if (hotel == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Hotel Not Found"
            });

        var hotelToUpdate = _mapper.Map<Hotel>(hotelUpdateDto);

        hotel.UpdatedOn = DateTime.Now;
        await _unitOfWork.Hotels.UpdateHotel(hotelToUpdate);
        await _unitOfWork.Complete();

        var hotelToReturn = _mapper.Map<HotelListDto>(hotelToUpdate);

        return Ok(new RequestDetails
        {
            Data = hotelToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Update
        });
    }

    /* ------------------------------ Delete Hotel ------------------------------ */
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHotel(int id)
    {
        var hotel = await _unitOfWork.Hotels.GetHotelById(id);

        if (hotel == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Hotel Not Found"
            });

        hotel.IsDeleted = true;
        hotel.UpdatedOn = DateTime.Now;
        await _unitOfWork.Hotels.UpdateHotel(hotel);
        await _unitOfWork.Complete();

        var hotelToReturn = _mapper.Map<HotelListDto>(hotel);

        return Ok(new RequestDetails
        {
            Data = hotelToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Delete
        });
    }

    /* ---------------------------- Add Hotel Review ---------------------------- */
    [HttpPost("review")]
    public async Task<IActionResult> AddHotelReview(ReivewAddDto reivewAddDto)
    {
        var hotel = await _unitOfWork.Hotels.GetHotelById(reivewAddDto.HotelId);

        if (hotel == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Hotel Not Found"
            });

        var guest = await _unitOfWork.Guests.GetCurrentGuest();

        var review = _mapper.Map<Review>(reivewAddDto);

        review.GuestId = guest.Id;

        await _unitOfWork.Hotels.AddHotelReview(review);
        await _unitOfWork.Complete();

        var reviewToReturn = _mapper.Map<ReviewListDto>(review);
        return Ok(new RequestDetails
        {
            Data = reviewToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Success
        });
    }

    [HttpPost("room")]
    public async Task<IActionResult> AddHotelRoom(RoomAddDto roomAddDto)
    {
        var hotel = await _unitOfWork.Hotels.GetHotelById(roomAddDto.HotelId);

        if (hotel == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Hotel Not Found"
            });

        var room = _mapper.Map<Room>(roomAddDto);

        await _unitOfWork.Hotels.AddHotelRoom(room);
        await _unitOfWork.Complete();

        var roomToReturn = _mapper.Map<RoomListDto>(room);
        return Ok(new RequestDetails
        {
            Data = roomToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Success
        });
    }

    [HttpPost("facility")]
    public async Task<IActionResult> AddHotelFacility(HotelFacilityAddDto hotelFacilityAddDto)
    {
        var hotel = await _unitOfWork.Hotels.GetHotelById(hotelFacilityAddDto.HotelId);

        if (hotel == null)
            return NotFound(new RequestDetails
            {
                Data = new { },
                Status = true,
                StatusCode = StatusCodes.Status404NotFound,
                Message = "Hotel Not Found"
            });

        var facility = _mapper.Map<HotelFacility>(hotelFacilityAddDto);

        await _unitOfWork.Hotels.AddHotelFacility(facility);
        await _unitOfWork.Complete();

        var facilityToReturn = _mapper.Map<HotelFacilityListDto>(facility);

        return Ok(new RequestDetails
        {
            Data = facilityToReturn,
            Status = true,
            StatusCode = StatusCodes.Status200OK,
            Message = Helper.Messages.Success
        });
    }
}


