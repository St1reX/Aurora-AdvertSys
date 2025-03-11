using Application.Shared.Address.Commands;
using Application.Shared.Address.DTOs;
using AutoMapper;

namespace Application.Shared.Address
{
    public class AddressMappingProfile : Profile
    {
        public AddressMappingProfile() 
        {
            CreateMap<Core.Entities.Shared.Address, AddressDTO>()
                .ReverseMap();

            CreateMap<SaveAdressCommandHandler, Core.Entities.Shared.Address>()
                .ReverseMap();
        }
    }
}
