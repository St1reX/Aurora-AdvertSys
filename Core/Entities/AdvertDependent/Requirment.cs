using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class Requirment
    {
        public int RequirmentID { get; set; }
        public string Description { get; set; } = default!;
        public int AdvertID { get; set; }

        public Advert Advert { get; set; } = default!;
    }
}
