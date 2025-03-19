using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserDependent.User.DTOs
{
    public class UserLoginDTO
    {
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
