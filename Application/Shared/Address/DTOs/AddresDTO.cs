﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Address.DTOs
{
    public class AddressDTO
    {
        public string? StreetNumber { get; set; }
        public string? Street { get; set; }
        public string City { get; set; } = default!;
        public string? Region { get; set; }
        public string Country { get; set; } = default!;
        public decimal Latitude { get; set; } = 0;
        public decimal Longitude { get; set; } = 0;
    }
}
