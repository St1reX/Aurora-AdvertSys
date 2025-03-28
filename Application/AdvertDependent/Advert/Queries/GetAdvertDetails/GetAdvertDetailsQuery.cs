using Application.AdvertDependent.Advert.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.Advert.Queries.GetAdvertDetails
{
    public class GetAdvertDetailsQuery : IRequest<AdvertDetailsDTO>
    {
        public int AdvertID { get; set; }
    }
}
