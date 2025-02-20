using Application.Adress.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company.DTOs
{
    public class CompanyDTO
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Website { get; set; } = default!;

        public AddressDTO Address { get; set; } = default!;
    }
}
