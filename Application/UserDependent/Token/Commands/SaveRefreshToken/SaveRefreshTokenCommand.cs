using Core.ValueObjects;
using MediatR;

namespace Application.UserDependent.Token.Commands.SaveRefreshToken
{
    public class SaveRefreshTokenCommand : IRequest
    {
        public string UserID { get; set; } = default!;
    }
}
