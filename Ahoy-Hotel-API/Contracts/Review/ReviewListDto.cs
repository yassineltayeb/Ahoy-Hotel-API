using Ahoy_Hotel_API.Models;

namespace Ahoy_Hotel_API.Contracts.Review;

/* -------------------------------------------------------------------------- */
/*                               Review List Dto                              */
/* -------------------------------------------------------------------------- */

public class ReviewListDto : BaseEntity
{
    public int Rating { get; set; }
    public string Description { get; set; }
    public string Guest { get; set; }
}
