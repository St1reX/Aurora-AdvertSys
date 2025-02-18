using Application.Adress.DTOs;
using AutoMapper;

namespace Application.Address
{
    public class AddressMappingProfile : Profile
    {
        public AddressMappingProfile() 
        {
            CreateMap<Core.Entities.Shared.Address, AddressDTO>()
                .ReverseMap();
        }
    }
}
