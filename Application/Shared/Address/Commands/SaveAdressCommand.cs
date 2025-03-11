using Application.Shared.Address.DTOs;
using MediatR;

namespace Application.Shared.Address.Commands
{
    public class SaveAdressCommand : AddressDTO, IRequest<int>
    {
    }
}
