using Core.Entities;
using Core.Entities.Shared;
using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.AdvertDependent
{
    public interface IAdvertRepository
    {
        Task<ICollection<Advert>?> GetAllAdverts(); 
        Task<ICollection<Advert>?> GetFilteredAdverts(AdvertFilter advertFilter);
        Task<Advert?> GetAdvertById(int id);
    }
}
