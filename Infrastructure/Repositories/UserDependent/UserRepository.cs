using Core.Entities;
using Core.Interfaces.UserDependent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.UserDependent
{
    public class UserRepository : IUserRepository
    {
        public Task CreateUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
