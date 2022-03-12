namespace Ahoy_Hotel_API.Models;

/* ---------------------------------- Room ---------------------------------- */

public class Room : BaseEntity
{
    public int RoomNo { get; set; }
    public int NoOfGuests { get; set; }
    public double Price { get; set; }
    public int HotelId { get; set; }
    public virtual Hotel Hotel { get; set; }
}
