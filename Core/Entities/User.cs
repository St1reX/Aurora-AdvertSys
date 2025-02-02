using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string ProfilePicture { get; set; } = default!;
        public string CV { get; set; } = default!;
        public string WorkSummary { get; set; } = default!;

        public int CurrentPositionID { get; set; } = default!;
        public int CurrentCompanyID { get; set; } = default!;
    }
}
