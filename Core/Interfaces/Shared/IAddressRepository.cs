using Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Shared
{
    public interface IAddressRepository
    {
        Task SaveAddress(Address address);
        Task<Address> GetAddressByID(int id);
    }
}
