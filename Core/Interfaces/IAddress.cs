using Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAddress
    {
        Task SaveAdress(Address address);
        Task<Address> GetByAddressID(int id);
    }
}
