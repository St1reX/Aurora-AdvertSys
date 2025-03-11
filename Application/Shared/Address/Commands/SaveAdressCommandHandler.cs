using AutoMapper;
using Core.Interfaces.Shared;
using MediatR;

namespace Application.Shared.Address.Commands
{
    public class SaveAdressCommandHandler : IRequestHandler<SaveAdressCommand, int>
    {
        private readonly IMapper mapper;
        private readonly IAddressRepository addressRepository;

        public SaveAdressCommandHandler(IMapper mapper, IAddressRepository addressRepository)
        {
            this.mapper = mapper;
            this.addressRepository = addressRepository;
        }

        public async Task<int> Handle(SaveAdressCommand request, CancellationToken cancellationToken)
        {
            var address = mapper.Map<Core.Entities.Shared.Address>(request);

            int insertedID = await addressRepository.SaveAddress(address);

            return insertedID;
        }
    }
}
