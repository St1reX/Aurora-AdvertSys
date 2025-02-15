using Application.Advert.DTOs;
using AutoMapper;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetTopAdverts
{
    public class GetTopAdvertsQueryHandler : IRequestHandler<GetTopAdvertsQuery, ICollection<AdvertDTO>?>
    {
        private readonly IAdvert advert;
        private readonly IMapper mapper;

        public GetTopAdvertsQueryHandler(IAdvert advert, IMapper mapper)
        {
            this.advert = advert;
            this.mapper = mapper;
        }
        public async Task<ICollection<AdvertDTO>?> Handle(GetTopAdvertsQuery request, CancellationToken cancellationToken)
        {
            var adverts = await advert.GetRange(request.Amount, request.Offset);
            var advertsDTO = mapper.Map<ICollection<AdvertDTO>?>(adverts);

            return advertsDTO;
        }
    }
}
