namespace Ahoy_Hotel_API.Contracts.Room;
/* -------------------------------------------------------------------------- */
/*                                Room Add Dto                                */
/* -------------------------------------------------------------------------- */
public class RoomAddDto
{
    public int RoomNo { get; set; }
    public int NoOfGuests { get; set; }
    public double Price { get; set; }
    public int HotelId { get; set; }
}