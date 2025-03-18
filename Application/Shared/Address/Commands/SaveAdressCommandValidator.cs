using Application.Shared.Address.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Address.Commands
{
    public class SaveAdressCommandValidator : AbstractValidator<SaveAdressCommand>
    {
        public SaveAdressCommandValidator()
        {
            RuleFor(x => x.StreetNumber)
                .MaximumLength(10);

            RuleFor(x => x.Street)
                .MaximumLength(25);

            RuleFor(x => x.City)
                .NotEmpty()
                .MaximumLength(35);

            RuleFor(x => x.Region)
                .MaximumLength(30);

            RuleFor(x => x.Country)
                .NotEmpty()
                .MaximumLength(35);
        }
    }
}
