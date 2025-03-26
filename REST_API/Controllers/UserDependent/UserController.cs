using Application.UserDependent.User.Commands.LoginUser;
using Application.UserDependent.User.Commands.RegisterUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
            var result = await mediator.Send(command);

            return Ok(result);
        }

    }
}
