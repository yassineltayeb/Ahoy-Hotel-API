namespace Ahoy_Hotel_API.Contracts.Review;
public class ReivewAddDto
{
    public int Rating { get; set; }
    public string Description { get; set; }
    public int HotelId { get; set; }
}