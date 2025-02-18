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
        public int CachedAddressID { get; set; }

        public int AddressID { get; set; }
        public Address Address { get; set; } = default!;
    }
}
