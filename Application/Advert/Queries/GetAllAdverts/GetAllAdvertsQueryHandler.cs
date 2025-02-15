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
        private readonly IAdvert advert;
        private readonly IMapper mapper;

        public GetAllAdvertsQueryHandler(IAdvert advert, IMapper mapper)
        {
            this.advert = advert;
            this.mapper = mapper;
        }

        public async Task<ICollection<AdvertDTO>?> Handle(GetAllAdvertsQuery request, CancellationToken cancellationToken)
        {
            var adverts = await advert.GetAll();
            var advertDTO = mapper.Map<ICollection<AdvertDTO>>(adverts);

            return advertDTO;
        }
    }
}
