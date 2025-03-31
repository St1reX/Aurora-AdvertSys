using Application.UserDependent.Token.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserDependent.Token.Commands.SaveRefreshToken
{
    public class SaveRefreshTokenCommand : IRequest
    {
        public string UserID { get; set; } = default!;
        public AuthTokens AuthTokens { get; set; } = default!;
    }
}
