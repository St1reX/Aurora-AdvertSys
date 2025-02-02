using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class Benefit
    {
        public int BenefitID { get; set; }
        public string BenefitName { get; set; } = default!;
        public int AdvertID { get; set; }
    }
}
