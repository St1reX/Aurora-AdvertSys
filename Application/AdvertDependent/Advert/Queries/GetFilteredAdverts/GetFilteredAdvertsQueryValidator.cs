using Core.Helpers;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.Advert.Queries.GetFilteredAdverts
{
    public class GetFilteredAdvertsQueryValidator : AbstractValidator<AdvertFilter>
    {
        public GetFilteredAdvertsQueryValidator()
        {
            RuleFor(x => x.Offset).GreaterThanOrEqualTo(0)
                .When(x => x.Offset.HasValue);

            RuleFor(x => x.Amount).GreaterThanOrEqualTo(0)
                .When(x => x.Amount.HasValue);

            RuleFor(x => x.CompanyID).GreaterThanOrEqualTo(0)
                .When(x => x.CompanyID.HasValue);

            RuleFor(x => x.PositionID).GreaterThanOrEqualTo(0)
                .When(x => x.PositionID.HasValue);

            RuleFor(x => x.SeniorityLevelID).GreaterThanOrEqualTo(0)
                .When(x => x.SeniorityLevelID.HasValue);

            RuleFor(x => x.MinSalary).GreaterThanOrEqualTo(0)
                .When(x => x.MinSalary.HasValue);
            RuleFor(x => x.MaxSalary).GreaterThanOrEqualTo(x => x.MinSalary)
                .When(x => x.MaxSalary.HasValue || x.MinSalary.HasValue);
            RuleFor(x => x.MaxSalary).GreaterThanOrEqualTo(0)
                .When(x => x.MaxSalary.HasValue);

            RuleFor(x => x.AcceptableDistance).GreaterThanOrEqualTo(0)
                .When(x => !string.IsNullOrEmpty(x.Location));
        }
    }
}
