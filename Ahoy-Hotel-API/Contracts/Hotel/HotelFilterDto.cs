using Ahoy_Hotel_API.Helpers.Pagination;

namespace Ahoy_Hotel_API.Contracts.Hotel;

/* -------------------------------------------------------------------------- */
/*                              Hotel Filter Dto                              */
/* -------------------------------------------------------------------------- */

public class HotelFilterDto : QueryStringParameters
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Location { get; set; }
    public string Facilities { get; set; }
}
