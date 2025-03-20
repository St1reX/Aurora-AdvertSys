using Application.UserDependent.User.DTOs;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.UserDependent.User.Commands.RegisterUser
{
    public class RegisterUserCommand : UserRegisterDTO, IRequest<IdentityResult>
    {
    }
}
