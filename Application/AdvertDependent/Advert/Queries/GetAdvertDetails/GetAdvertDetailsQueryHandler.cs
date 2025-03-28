using Application.AdvertDependent.Advert.DTOs;
using Application.AdvertDependent.Advert.Events.AdvertViewed;
using AutoMapper;
using Core.Interfaces.AdvertDependent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.Advert.Queries.GetAdvertDetails
{
    public class GetAdvertDetailsQueryHandler : IRequestHandler<GetAdvertDetailsQuery, AdvertDetailsDTO>
    {
        private readonly IAdvertRepository advertRepository;
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public GetAdvertDetailsQueryHandler(IAdvertRepository advertRepository, IMapper mapper, IMediator mediator)
        {
            this.advertRepository = advertRepository;
            this.mapper = mapper;
            this.mediator = mediator;
        }

        public async Task<AdvertDetailsDTO> Handle(GetAdvertDetailsQuery request, CancellationToken cancellationToken)
        {
            var advertDetails = await advertRepository.GetAdvertById(request.AdvertID);
            if(advertDetails == null)
            {
                throw new Exception("Advert not found");
            }
            var advertDetailsDTO = mapper.Map<AdvertDetailsDTO>(advertDetails);

            await mediator.Publish(new AdvertViewedEvent { AdvertId = request.AdvertID });

            return advertDetailsDTO;
        }
    }
}
