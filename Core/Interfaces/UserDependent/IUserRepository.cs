using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.UserDependent
{
    public interface IUserRepository
    {
        Task CreateUser(ApplicationUser user);
    }
}
