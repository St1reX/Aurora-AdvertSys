using Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Experience
{
    public class ExperienceDuty
    {
        public int ExperienceDutyID { get; set; }
        public string DutyID { get; set; } = default!;
        public int ExperienceID { get; set; }

        public Experience Experience { get; set; } = default!;
        public Duty Duty { get; set; } = default!;
    }
}
