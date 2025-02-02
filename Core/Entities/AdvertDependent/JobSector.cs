using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class JobSector
    {
        public int JobSectorID { get; set; }
        public string JobSectorName { get; set; } = default!;

        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
    }
}
