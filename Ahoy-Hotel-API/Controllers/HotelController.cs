﻿using Ahoy_Hotel_API.Contracts.Hotel;
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
}

