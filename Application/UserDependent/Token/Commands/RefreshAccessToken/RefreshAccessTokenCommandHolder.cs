using Core.ValueObjects;
using Infrastructure.Security;
using MediatR;

namespace Application.UserDependent.Token.Commands.RefreshAccessToken
{
    public class RefreshAccessTokenCommandHolder : IRequestHandler<RefreshAccessTokenCommand, AuthTokens>
    {
        private readonly IJWTGenerator jWTGenerator;

        public RefreshAccessTokenCommandHolder(IJWTGenerator jWTGenerator)
        {
            this.jWTGenerator = jWTGenerator;
        }
        public async Task<AuthTokens> Handle(RefreshAccessTokenCommand request, CancellationToken cancellationToken)
        {
            var tokens = await jWTGenerator.RefreshAccessToken(request.RefreshToken);

            return tokens;
        }
    }
}
