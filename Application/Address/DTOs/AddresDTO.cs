using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Adress.DTOs
{
    public class AddressDTO
    {
        public string? StreetNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string Country { get; set; } = default!;
        public decimal Latitude { get; set; } = default!;
        public decimal Longitude { get; set; } = default!;
    }
}
