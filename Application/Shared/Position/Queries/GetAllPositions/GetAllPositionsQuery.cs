using Application.Shared.Position.DTOs;
using MediatR;

namespace Application.Shared.Position.Queries.GetAllPositions
{
    public class GetAllPositionsQuery : IRequest<ICollection<PositionDTO>?>
    {

    }
}
