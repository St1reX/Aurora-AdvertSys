using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class AdvertApplication
    {
        public int AdvertApplicationID { get; set; }
        public int AdvertID { get; set; }
        public string UserID { get; set; } = default!;
        public DateTime ApplicationDate { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsRejected { get; set; }
        public bool IsPending { get; set; }


        public Advert Advert { get; set; } = default!;
        public ApplicationUser User { get; set; } = default!;
    }
}
