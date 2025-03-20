﻿using Application.UserDependent.User.DTOs;
using AutoMapper;
using Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.UserDependent.User.Commands.LoginUser
{
    public class LoginCommandHandler : IRequestHandler<LoginUserCommand, string>
    {
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public LoginCommandHandler(IMapper mapper, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var result = await signInManager.PasswordSignInAsync(request.UserName, request.Password, false, false);
            var user = await userManager.FindByNameAsync(request.UserName);


            var token = jWTGenerator.GenerateToken(user!);
            return token;

            throw new NotImplementedException();
        }
    }
}
