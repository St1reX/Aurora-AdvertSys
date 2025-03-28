using Core.Interfaces.AdvertDependent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.Advert.Commands.AddAdvertExposure
{
    public class AddAdvertExposureCommandHandler : IRequestHandler<AddAdvertExposureCommand>
    {
        private readonly IAdvertRepository advertRepository;

        public AddAdvertExposureCommandHandler(IAdvertRepository advertRepository)
        {
            this.advertRepository = advertRepository;
        }
        public async Task Handle(AddAdvertExposureCommand request, CancellationToken cancellationToken)
        {
            await advertRepository.AddAdvertExposure(request.AdvertID);
        }
    }
}
