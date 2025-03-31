using Application.UserDependent.User.DTOs;
using Core.ValueObjects;
using MediatR;

namespace Application.UserDependent.User.Commands.LoginUser
{
    public class LoginUserCommand : UserLoginDTO, IRequest<AuthTokens>
    {
    }
}
