using Core.Entities.Shared;
using Core.Interfaces.Shared;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Shared
{
    public class PositionRepository : IPositionRepository
    {
        private readonly AuroraDbContext dbContext;

        public PositionRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ICollection<Position>?> GetAllPositions()
        {
            var positions = await dbContext.Position
                .ToListAsync();

            return positions;
        }

        public async Task<ICollection<Position>?> GetPositionsAutocomplete(string positionName)
        {
            var positions = await dbContext.Position
                .Where(x => x.PositionName.StartsWith(positionName))
                .ToListAsync();

            return positions;
        }
    }
}
