using Application.UserDependent.User.Events.UserLogged;
using AutoMapper;
using Core.Entities;
using Core.ValueObjects;
using Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.UserDependent.User.Commands.LoginUser
{
    public class LoginCommandHandler : IRequestHandler<LoginUserCommand, AuthTokens>
    {
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IJWTGenerator jWTGenerator;
        private readonly IMediator mediator;

        public LoginCommandHandler(IMapper mapper, IJWTGenerator jWTGenerator, IMediator mediator, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.jWTGenerator = jWTGenerator;
            this.mediator = mediator;
        }
        public async Task<AuthTokens> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var result = await signInManager.PasswordSignInAsync(request.UserName, request.Password, false, false);

            if (!result.Succeeded)
            {
                throw new Exception("Unaouthorized. Incorrect mail or password.");
            }

            var user = await userManager.FindByNameAsync(request.UserName);


            var token = jWTGenerator.GenerateToken(user!);
            var refreshToken = jWTGenerator.GenerateRefreshToken();
            AuthTokens authTokens = new AuthTokens() { Token = token, RefreshToken = refreshToken };

            await mediator.Publish(new UserLoggedEvent { AuthTokens = authTokens, UserID = user!.Id });

            return authTokens;
        }
    }
}
