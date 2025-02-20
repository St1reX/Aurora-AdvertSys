using Application.Position.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Position.Queries.GetPositionsAutocomplete
{
    public class GetPositionsAutocompleteQuery : IRequest<ICollection<PositionDTO>?>
    {
        public string? PositionName { get; set; }
    }
}
