using Application.Shared.Company.Queries.GetAllCompanies;
using Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers.UserDependent
{
    [Route("api/company")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMediator mediator;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IMediator mediator, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.mediator = mediator;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        //[HttpPost]
        //public async Task<IActionResult> Register()
        //{
            
        //}
    }
}
