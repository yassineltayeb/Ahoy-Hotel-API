﻿namespace Ahoy_Hotel_API.Models
{
    public class ElasticsearchHotel : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
