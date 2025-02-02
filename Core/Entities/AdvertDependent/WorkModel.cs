using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class WorkModel
    {
        public int WorkModelID { get; set; }
        public string WorkModelName { get; set; } = default!;

        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
    }
}
