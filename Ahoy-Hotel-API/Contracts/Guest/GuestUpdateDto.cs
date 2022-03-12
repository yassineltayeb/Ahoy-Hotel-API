namespace Ahoy_Hotel_API.Contracts.Guest;

public class GuestUpdateDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
