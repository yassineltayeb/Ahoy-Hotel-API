namespace Ahoy_Hotel_API.Models;

/* -------------------------------------------------------------------------- */
/*                                    Hotel                                   */
/* -------------------------------------------------------------------------- */

public class Hotel : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public virtual List<HotelFacility> Facilities { get; set; }
    public virtual List<HotelImage> Images { get; set; }
    public virtual List<Review> Reviews { get; set; }
    public virtual List<Room> Rooms { get; set; }

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public Hotel()
    {
        Facilities = new List<HotelFacility>();
        Images = new List<HotelImage>();
        Rooms = new List<Room>();
        Reviews = new List<Review>();
    }
}
