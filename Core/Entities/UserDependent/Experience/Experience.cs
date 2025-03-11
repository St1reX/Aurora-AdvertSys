using Core.Entities.AdvertDependent;
using Core.Entities.Shared;
using Core.Entities.Shared.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Experience
{
    public class Experience
    {
        public int ExperienceID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int PositionID { get; set; }
        public int? CompanyID { get; set; }
        public string UserID { get; set; } = default!;

        public Position Position { get; set; } = default!;
        public Company? Company { get; set; } = default!;
        public ApplicationUser User { get; set; } = default!;

        public ICollection<ExperienceDuty> ExperienceDuties{ get; set; } = new List<ExperienceDuty>();
    }
}
