using Core.Entities.UserDependent.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class Position
    {
        public int PositionID { get; set; }
        public string Name { get; set; } = default!;

        ICollection<Advert> Adverts { get; set; } = new List<Advert>();

        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
