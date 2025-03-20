using Application.UserDependent.User.DTOs;
using MediatR;

namespace Application.UserDependent.User.Commands.LoginUser
{
    public class LoginUserCommand : UserLoginDTO, IRequest<string>
    {
    }
}
