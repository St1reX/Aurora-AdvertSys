using Application.Advert.DTOs;
using AutoMapper;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetAllAdverts
{
    public class GetAllAdvertsQueryHandler : IRequestHandler<GetAllAdvertsQuery, ICollection<AdvertDTO>?>
    {
        private readonly IAdvertRepository advert;
        private readonly IMapper mapper;

        public GetAllAdvertsQueryHandler(IAdvertRepository advert, IMapper mapper)
        {
            this.advert = advert;
            this.mapper = mapper;
        }

        public async Task<ICollection<AdvertDTO>?> Handle(GetAllAdvertsQuery request, CancellationToken cancellationToken)
        {
            var adverts = await advert.GetAllAdverts();
            var advertsDTO = mapper.Map<ICollection<AdvertDTO>?>(adverts);

            return advertsDTO;
        }
    }
}
