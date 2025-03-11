using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent
{
    public class Link
    {
        public int LinkID { get; set; }
        public string URL { get; set; } = default!;
        public string UserID { get; set; } = default!;

        public ApplicationUser User { get; set; } = default!;
    }
}
