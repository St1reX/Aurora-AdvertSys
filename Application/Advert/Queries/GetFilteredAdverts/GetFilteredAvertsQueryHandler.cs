using Application.Advert.DTOs;
using AutoMapper;
using Core.Helpers;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetFilteredAdverts
{
    public class GetFilteredAvertsQueryHandler : IRequestHandler<GetFilteredAdvertsQuery, ICollection<AdvertDTO>?>
    {

        private readonly IAdvert advert;
        private readonly IMapper mapper;

        public GetFilteredAvertsQueryHandler(IAdvert advert, IMapper mapper)
        {
            this.advert = advert;
            this.mapper = mapper;
        }

        public async Task<ICollection<AdvertDTO>?> Handle(GetFilteredAdvertsQuery request, CancellationToken cancellationToken)
        {
            var filter = mapper.Map<AdvertFilter>(request);

            var adverts = await advert.GetFiltered(filter);
            var advertsDTO = mapper.Map<ICollection<AdvertDTO>?>(adverts);

            return advertsDTO;
        }
    }
}
