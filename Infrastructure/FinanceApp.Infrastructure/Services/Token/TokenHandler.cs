using FinanceApp.Application.Abstruction.Token;
using FinanceApp.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinanceApp.Infrastructure.Services.Token
{
    public class TokenHandler : ITokenHandler
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<FinanceAppUser> _userManager;
        private readonly RoleManager<FinanceAppRole> _roleManager;
        public TokenHandler(IConfiguration configuration, UserManager<FinanceAppUser> userManager, RoleManager<FinanceAppRole> roleManager)
        {
            _configuration = configuration;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Application.Models.Token> GenerateAccessTokenAsync(int min, FinanceAppUser user)
        {
            Application.Models.Token token = new();
            // sec. key in simetriği alınır
            SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(_configuration["Token:Key"]));
            //şifrelenniş kimlik olusuturulur
            SigningCredentials signingCredentials = new(key,SecurityAlgorithms.HmacSha256);
            
            token.Expiration = DateTime.UtcNow.AddMinutes(min);
            var claims = new List<Claim>();
            claims.Add(new Claim("Fullname", user.Fullname));
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            JwtSecurityToken jwtSecurityToken = new(
                audience : _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires: token.Expiration,
                notBefore : DateTime.UtcNow,//üretildikten ne kadar sonra devreye girsin?. hemen olacak sekilde ayarladık
                signingCredentials: signingCredentials,
                claims : claims
                );

            JwtSecurityTokenHandler tokenHandler = new();
            token.AccessToken =  tokenHandler.WriteToken(jwtSecurityToken);
            token.RefreshToken = GenerateRefreshToken();
            

            return token;
        }

        public string GenerateRefreshToken()
        {
            string guid = Guid.NewGuid().ToString().Replace("-","") + Guid.NewGuid().ToString().Replace("-","");
            byte[] bytes = Encoding.ASCII.GetBytes(guid.Replace("=",""));

            return Convert.ToBase64String(bytes);
        }
    }
}
