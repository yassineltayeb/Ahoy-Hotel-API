
namespace Ahoy_Hotel_API.Models;

/* -------------------------------------------------------------------------- */
/*                                   Booking                                  */
/* -------------------------------------------------------------------------- */

public class Booking : BaseEntity
{
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public string PaymentType { get; set; }
    public string IdentificationType { get; set; }
    public string IdentificationID { get; set; }
    public bool IsConfirmed { get; set; }
    public double Discount { get; set; }
    public double PaidAmount { get; set; }
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public int GuestId { get; set; }
    public virtual Guest Guest { get; set; }
}
