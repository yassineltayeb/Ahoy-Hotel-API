namespace Ahoy_Hotel_API.Models;

/* -------------------------------------------------------------------------- */
/*                                 Hotel Image                                */
/* -------------------------------------------------------------------------- */

public class HotelImage : BaseEntity
{
    public string Url { get; set; }
    public int HotelId { get; set; }
    public virtual Hotel Hotel { get; set; }
}
