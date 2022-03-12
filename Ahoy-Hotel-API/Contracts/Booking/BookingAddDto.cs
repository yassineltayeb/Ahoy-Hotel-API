namespace Ahoy_Hotel_API.Contracts.Booking;

/* -------------------------------------------------------------------------- */
/*                               Booking Add Dto                              */
/* -------------------------------------------------------------------------- */

public class BookingAddDto
{
    public int Id { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public string PaymentType { get; set; }
    public string IdentificationType { get; set; }
    public string IdentificationID { get; set; }
    public bool IsConfirmed { get; set; }
    public double Discount { get; set; }
    public double PaidAmount { get; set; }
    public string Room { get; set; }
}
