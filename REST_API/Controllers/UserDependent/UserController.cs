using Application.UserDependent.User.Commands.LoginUser;
using Application.UserDependent.User.Commands.RegisterUser;
using Application.UserDependent.Token.Commands.RefreshAccessToken;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Core.ValueObjects;
using Application.Exceptions;

namespace REST_API.Controllers.UserDependent
{
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMediator mediator;
        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterUserCommand command)
        {
            var result = await mediator.Send(command);

            if(!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Created();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginUserCommand command)
        {
            var result = new AuthTokens();

            try
            {
                result = await mediator.Send(command);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }

            return Ok(result);
        }


        [HttpPost]
        [Route("refresh-token")]
        [Authorize]
        public async Task<IActionResult> RefreshToken(RefreshAccessTokenCommand command)
        {
            var newToken = new AuthTokens();

            try
            {
                newToken = await mediator.Send(command);
            }
            catch(InvalidRefreshTokenException ex)
            {
                return Unauthorized(ex.Message);
            }


            return Ok(newToken);
        }
    }
}
