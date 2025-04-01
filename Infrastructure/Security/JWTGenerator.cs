using Application.Exceptions;
using Core.Entities;
using Core.Entities.UserDependent;
using Core.ValueObjects;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Security
{
    public class JWTGenerator : IJWTGenerator
    {
        private readonly IConfiguration configuration;
        private readonly AuroraDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public JWTGenerator(IConfiguration configuration, AuroraDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.configuration = configuration;
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public string GenerateToken(ApplicationUser applicationUser)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, applicationUser.Id!)
            };

            Console.WriteLine("Role: ");
            foreach (var role in userManager.GetRolesAsync(applicationUser).Result)
            {
                claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, role));
                Console.WriteLine(role);
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                issuer: configuration["JWT:Issuer"],
                audience: configuration["JWT:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GenerateRefreshToken()
        {
            return Guid.NewGuid().ToString();
        }

        public async Task<string> SaveRefreshToken(string userID)
        {
            var previousToken = dbContext.RefreshToken.FirstOrDefault(x => x.UserID == userID && x.ExpiryDate > DateTime.Now);

            if (previousToken == null)
            {
                var expireTime = DateTime.Now + TimeSpan.FromHours(System.Convert.ToInt32(configuration["JWT:RefreshExpireTime"]));
                var token = GenerateRefreshToken();
                dbContext.RefreshToken.Add(new RefreshToken { Token = token, UserID = userID, ExpiryDate = expireTime });

                await dbContext.SaveChangesAsync();

                return token;
            }

            return previousToken.Token;

        }

        public async Task<AuthTokens> RefreshAccessToken(string refreshToken)
        {
            var refreshToken_ = dbContext.RefreshToken.
                Include(x => x.User).
                FirstOrDefault(x => x.Token == refreshToken && x.ExpiryDate >= DateTime.Now);

            var authTokens = new AuthTokens();

            if (refreshToken_ == null)
            {
                throw new InvalidRefreshTokenException("Invalid refresh token.");
            }
            else
            { 
                refreshToken_.Token = GenerateRefreshToken();
                refreshToken_.ExpiryDate = DateTime.Now + TimeSpan.FromHours(System.Convert.ToInt32(configuration["JWT:RefreshExpireTime"]));

                authTokens.Token = GenerateToken(refreshToken_.User);
                authTokens.RefreshToken = refreshToken_.Token;

                await dbContext.SaveChangesAsync();
            }

            return authTokens;
        }
    }
}
