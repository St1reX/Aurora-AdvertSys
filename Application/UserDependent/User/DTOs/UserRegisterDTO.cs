using Application.Shared.Address.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserDependent.User.DTOs
{
    public class UserRegisterDTO
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? CVPath { get; set; }
        public string? WorkSummary { get; set; }

        public int? PositionID { get; set; }
        public int? CompanyID { get; set; }
        public int UserAddressID { get; set; }

        public AddressDTO Address { get; set; } = default!;
    }
}
