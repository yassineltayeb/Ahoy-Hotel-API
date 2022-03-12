namespace Ahoy_Hotel_API.Models;

/* -------------------------------------------------------------------------- */
/*                                   Review                                   */
/* -------------------------------------------------------------------------- */

public class Review : BaseEntity
{

    public int Rating { get; set; }
    public string Description { get; set; }

    public int HotelId { get; set; }
    public virtual Hotel Hotel { get; set; }
    public int GuestId { get; set; }
    public virtual Guest Guest { get; set; }
}
