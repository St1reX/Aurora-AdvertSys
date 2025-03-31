using Core.ValueObjects;
using MediatR;

namespace Application.UserDependent.User.Events.UserLogged
{
    public class UserLoggedEvent : INotification
    {
        public string UserID { get; set; } = default!;
        public AuthTokens AuthTokens { get; set; } = default!;
    }
}
