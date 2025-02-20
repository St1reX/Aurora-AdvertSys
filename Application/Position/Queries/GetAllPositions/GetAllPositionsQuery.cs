using Application.Position.DTOs;
using MediatR;

namespace Application.Position.Queries.GetAllPositions
{
    public class GetAllPositionsQuery : IRequest<ICollection<PositionDTO>?>
    {

    }
}
