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

        private readonly IAdvertRepository advert;
        private readonly IMapper mapper;

        public GetFilteredAvertsQueryHandler(IAdvertRepository advert, IMapper mapper)
        {
            this.advert = advert;
            this.mapper = mapper;
        }

        public async Task<ICollection<AdvertDTO>?> Handle(GetFilteredAdvertsQuery request, CancellationToken cancellationToken)
        {
            var filter = mapper.Map<AdvertFilter>(request);

            var adverts = await advert.GetFilteredAdverts(filter);

            var advertDTO = mapper.Map<ICollection<AdvertDTO>?>(adverts);

            return advertDTO;
        }
    }
}
