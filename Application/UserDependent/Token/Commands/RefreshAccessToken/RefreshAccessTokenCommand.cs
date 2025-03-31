using Core.ValueObjects;
using MediatR;

namespace Application.UserDependent.Token.Commands.RefreshAccessToken
{
    public class RefreshAccessTokenCommand : IRequest<AuthTokens>
    {
        public string RefreshToken { get; set; } = default!;
    }
}
