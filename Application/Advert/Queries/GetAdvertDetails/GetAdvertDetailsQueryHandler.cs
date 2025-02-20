using Application.Advert.DTOs;
using AutoMapper;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetAdvertDetails
{
    public class GetAdvertDetailsQueryHandler : IRequestHandler<GetAdvertDetailsQuery, AdvertDetailsDTO>
    {
        private readonly IAdvertRepository advertRepository;
        private readonly IMapper mapper;

        public GetAdvertDetailsQueryHandler(IAdvertRepository advertRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.mapper = mapper;
        }

        public async Task<AdvertDetailsDTO> Handle(GetAdvertDetailsQuery request, CancellationToken cancellationToken)
        {
            var advertDetails = await advertRepository.GetAdvertById(request.Id);
            var advertDetailsDTO = mapper.Map<AdvertDetailsDTO>(advertDetails);
            return advertDetailsDTO;
        }
    }
}
