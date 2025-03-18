using Application.Shared.Address.Commands;
using Application.Shared.Address.DTOs;
using Application.UserDependent.User.DTOs;
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

            CreateMap<UserRegisterDTO, SaveAdressCommand>()
                .ForMember(dto => dto.City, opt => opt.MapFrom(src => src.UserAddress.City))
                .ForMember(dto => dto.Country, opt => opt.MapFrom(src => src.UserAddress.Country))
                .ForMember(dto => dto.Latitude, opt => opt.MapFrom(src => src.UserAddress.Latitude))
                .ForMember(dto => dto.Longitude, opt => opt.MapFrom(src => src.UserAddress.Longitude))
                .ForMember(dto => dto.Region, opt => opt.MapFrom(src => src.UserAddress.Region))
                .ForMember(dto => dto.Street, opt => opt.MapFrom(src => src.UserAddress.Street))
                .ForMember(dto => dto.StreetNumber, opt => opt.MapFrom(src => src.UserAddress.StreetNumber));

        }
    }
}
