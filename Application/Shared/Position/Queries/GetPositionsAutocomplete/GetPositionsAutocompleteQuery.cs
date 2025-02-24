using Application.Shared.Position.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Position.Queries.GetPositionsAutocomplete
{
    public class GetPositionsAutocompleteQuery : IRequest<ICollection<PositionDTO>?>
    {
        public string? PositionName { get; set; }
    }
}
