namespace Ahoy_Hotel_API.Contracts.Guest;

/* -------------------------------------------------------------------------- */
/*                             Guest Register Dto                             */
/* -------------------------------------------------------------------------- */

public class GuestRegisterDto
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}