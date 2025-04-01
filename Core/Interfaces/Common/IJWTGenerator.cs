using Core.Entities;
using Core.ValueObjects;

namespace Infrastructure.Security
{
    public interface IJWTGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
        string GenerateRefreshToken();
        Task<string> SaveRefreshToken(string userID);
        Task<AuthTokens> RefreshAccessToken(string refreshToken);
    }
}
