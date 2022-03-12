using Ahoy_Hotel_API.Models;

namespace Ahoy_Hotel_API.Contracts.Guest;

/* -------------------------------------------------------------------------- */
/*                               Guest List Dto                               */
/* -------------------------------------------------------------------------- */

public class GuestListDto : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
}
