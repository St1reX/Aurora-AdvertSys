using Application.Shared.Address.Commands;
using Application.UserDependent.User.DTOs;
using AutoMapper;
using Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers.UserDependent
{
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IMediator mediator, IMapper mapper, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            var userAddressCommand = mapper.Map<SaveAdressCommand>(userRegisterDTO);
            var addressID = await mediator.Send(userAddressCommand);
            userRegisterDTO.UserAddressID = addressID;

            var appUser = mapper.Map<ApplicationUser>(userRegisterDTO);
            var result = await userManager.CreateAsync(appUser, userRegisterDTO.Password);

            if(!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(UserLoginDTO userLoginDTO)
        {
            var result = await signInManager.PasswordSignInAsync(userLoginDTO.Email, userLoginDTO.Password, false, false);

            if (!result.Succeeded)
            {
                return BadRequest("Invalid login attempt");
            }

            return Ok(result);
        }

    }
}
