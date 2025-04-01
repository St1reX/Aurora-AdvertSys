using Infrastructure.Security;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserDependent.Token.Commands.SaveRefreshToken
{
    public class SaveRefreshTokenCommandHandler : IRequestHandler<SaveRefreshTokenCommand>
    {
        private readonly IJWTGenerator jWTGenerator;

        public SaveRefreshTokenCommandHandler(IJWTGenerator jWTGenerator)
        {
            this.jWTGenerator = jWTGenerator;
        }
        public async Task Handle(SaveRefreshTokenCommand request, CancellationToken cancellationToken)
        {
            await jWTGenerator.SaveRefreshToken(request.UserID);
        }
    }
}
