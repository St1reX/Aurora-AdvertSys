using Core.Entities;
using Core.ValueObjects;

namespace Infrastructure.Security
{
    public interface IJWTGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
        string GenerateRefreshToken();
        Task SaveRefreshToken(string refreshToken, string userID);
        Task<AuthTokens> RefreshAccessToken(string refreshToken);
    }
}
