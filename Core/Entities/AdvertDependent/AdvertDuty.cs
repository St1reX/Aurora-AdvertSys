using Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class AdvertDuty
    {
        public int AdvertDutyID { get; set; }
        public int DutyID { get; set; }
        public int AdvertID { get; set; }

        public Duty Duty { get; set; } = default!;
    }
}
