using Core.Entities;
using Core.Entities.UserDependent;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
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

        public async Task SaveRefreshToken(string refreshToken, string userID)
        {
            var expireTime = DateTime.Now + TimeSpan.FromHours(System.Convert.ToInt32(configuration["JWT:RefreshExpireTime"]));

            dbContext.RefreshToken.Add(new RefreshToken { Token = refreshToken, UserID = userID, ExpiryDate = expireTime});

            await dbContext.SaveChangesAsync();
        }
    }
}
