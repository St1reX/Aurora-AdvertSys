using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent
{
    public class RefreshToken
    {
        public int TokenID { get; set; }
        public string Token { get; set; } = default!;
        public string UserID { get; set; } = default!;
        public DateTime ExpiryDate { get; set; }

        public ApplicationUser User { get; set; } = default!;
    }
}
