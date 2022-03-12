namespace Ahoy_Hotel_API.Models;

/* -------------------------------------------------------------------------- */
/*                                    Guest                                   */
/* -------------------------------------------------------------------------- */

public class Guest : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public virtual List<Review> Reviews { get; set; }
    public virtual List<Booking> Bookings { get; set; }

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public Guest()
    {
        Reviews = new List<Review>();
        Bookings = new List<Booking>();
    }

}
