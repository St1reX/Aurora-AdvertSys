using Core.Entities.AdvertDependent;
using Core.Entities.UserDependent.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Shared
{
    public class Duty
    {
        public int DutyID { get; set; }
        public string DutyName { get; set; } = default!;

        public ICollection<ExperienceDuty> ExperienceDuties { get; set; } = new List<ExperienceDuty>();
        public ICollection<AdvertDuty> AdvertDuties { get; set; } = new List<AdvertDuty>();
    }
}
