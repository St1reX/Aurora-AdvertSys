using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAdvert
    {
        Task<ICollection<Advert>?> GetAll(); 
        Task<ICollection<Advert>?> GetRange(int amount, int offset);
    }
}
