using Core.Entities;

namespace Infrastructure.Security
{
    public interface IJWTGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
