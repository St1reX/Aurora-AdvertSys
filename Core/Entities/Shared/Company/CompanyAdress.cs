using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Shared.Company
{
    public class CompanyAdress
    {
        public int CompanyAdressID { get; set; }
        public string StreetNumber { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Region { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string Longitude { get; set; } = default!;
        public string Latitude { get; set; } = default!;

        public int CompanyID { get; set; }

        public Company Company { get; set; } = default!;
    }
}
