using Application.UserDependent.User.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserDependent.User.Commands.CreateUser
{
    public class UserRegisterDTOValidator : AbstractValidator<UserRegisterDTO>
    {
        public UserRegisterDTOValidator() 
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email is required");
            RuleFor(x => x.UserAddress).NotNull().WithMessage("Address is required");

            RuleFor(x => x.CVPath)
               .Matches(@"^.*\.(doc|docx|pdf)$")
               .WithMessage("Invalid file format. Only .doc, .docx and .pdf files are allowed")
               .When(x => !string.IsNullOrEmpty(x.CVPath));

            RuleFor(x => x.WorkSummary).MaximumLength(500).WithMessage("Work summary can't be longer than 500 characters");
        }
    }
}
