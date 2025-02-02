using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class EmploymentType
    {
        public int EmploymentTypeID { get; set; }
        public string EmploymentTypeName { get; set; } = default!;

        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
    }
}
