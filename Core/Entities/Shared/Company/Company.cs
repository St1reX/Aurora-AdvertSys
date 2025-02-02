using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Shared.Company
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Website { get; set; } = default!;
    }
}
