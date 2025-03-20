using Application.Shared.Address.Commands;
using Application.UserDependent.User.DTOs;
using AutoMapper;
using Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.UserDependent.User.Commands.RegisterUser
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, IdentityResult>
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly UserManager<ApplicationUser> userManager;

        public RegisterUserCommandHandler(IMapper mapper, IMediator mediator, UserManager<ApplicationUser> userManager)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.userManager = userManager;
        }

        public async Task<IdentityResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var userAddressCommand = mapper.Map<SaveAdressCommand>(request);
            var addressID = await mediator.Send(userAddressCommand);
            request.UserAddressID = addressID;

            var appUser = mapper.Map<ApplicationUser>(request);
            var result = await userManager.CreateAsync(appUser, request.Password);

            return result;
        }
    }
}
