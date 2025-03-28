using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class AdvertExposures
    {
        public int AdvertExposuresID { get; set; }
        public int ExposureAmount { get; set; }
        public DateTime ExposureDate { get; set; }
        public int AdvertID { get; set; }


        public Advert Advert { get; set; } = default!;
    }
}
