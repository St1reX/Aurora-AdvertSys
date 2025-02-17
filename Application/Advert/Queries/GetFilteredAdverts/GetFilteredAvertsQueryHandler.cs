using Application.Advert.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetFilteredAdverts
{
    internal class GetFilteredAvertsQueryHandler : IRequestHandler<GetFilteredAdvertsQuery, ICollection<AdvertDTO?>>
    {
        public Task<ICollection<AdvertDTO?>> Handle(GetFilteredAdvertsQuery request, CancellationToken cancellationToken)
        {
            
        }
    }
}
