using Application.UserDependent.Token.Commands.SaveRefreshToken;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserDependent.User.Events.UserLogged
{
    public class UserLoggedEventHandler : INotificationHandler<UserLoggedEvent>
    {
        private readonly IMediator mediator;

        public UserLoggedEventHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task Handle(UserLoggedEvent notification, CancellationToken cancellationToken)
        {
            await mediator.Send(new SaveRefreshTokenCommand() { AuthTokens = notification.AuthTokens, UserID = notification.UserID});
        }
    }
}
