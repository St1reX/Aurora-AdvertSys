using Application.Advert.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetAdvertDetails
{
    public class GetAdvertDetailsQuery : IRequest<AdvertDetailsDTO>
    {
        public int Id { get; set; }
    }
}
