using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent
{
    public class RefreshToken
    {
        public Guid TokenID { get; set; }
        public string Token { get; set; } = default!;
        public Guid UserID { get; set; }
        public DateTime ExpiryDate { get; set; }

        public ApplicationUser ApplicationUser { get; set; } = default!;
    }
}
