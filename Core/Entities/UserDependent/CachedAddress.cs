using Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent
{
    public class CachedAddress
    {
        public int CachedLocationID { get; set; }

        public int CachedAdressID { get; set; }
        public Address CachedAdress { get; set; } = default!;
    }
}
