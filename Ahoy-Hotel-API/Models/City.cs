﻿namespace Ahoy_Hotel_API.Models;

/* -------------------------------------------------------------------------- */
/*                                    City                                    */
/* -------------------------------------------------------------------------- */

public class City : BaseEntity
{
    public string Name { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
}
