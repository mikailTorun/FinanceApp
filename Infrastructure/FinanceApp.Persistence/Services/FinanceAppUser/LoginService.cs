using FinanceApp.Application.Abstruction.Services.FinanceAppUser;
using FinanceApp.Application.Abstruction.Token;
using FinanceApp.Application.Features.FinanceAppUser.Commands;
using FinanceApp.Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using e = FinanceApp.Domain.Entities.Common;
namespace FinanceApp.Persistence.Services.FinanceAppUser
{
    public class LoginService : ILoginService
    {
        private readonly UserManager<e.FinanceAppUser> _userManager;
        private readonly SignInManager<e.FinanceAppUser> _signInManager;
        private readonly RoleManager<e.FinanceAppRole> _roleManager;
        private readonly ITokenHandler _tokenHandler;
        private readonly IFinanceAppUserService _appUserService;

        public LoginService(UserManager<e.FinanceAppUser> userManager, SignInManager<e.FinanceAppUser> signInManager, ITokenHandler tokenHandler, IFinanceAppUserService appUserService, RoleManager<e.FinanceAppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
            _appUserService = appUserService;
            _roleManager = roleManager;
        }

        public async Task<LoginUserResponse> Login(LoginUserRequest loginRequest)
        {
            e.FinanceAppUser user = await _userManager.FindByNameAsync(loginRequest.Username);
            if (user == null)
            {
                return new() { IsSucceed = false, Message = "Kullanıcı Bulunamadı" };
            }

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, loginRequest.Password, false);
            if (result.Succeeded)// Authentication sağlandı
            {
                Token token = await _tokenHandler.GenerateAccessTokenAsync(1, user);
                user.RefreshToken = token.RefreshToken;
                await _appUserService.UpdateRefreshToken(token.RefreshToken, user, token.Expiration, 1);
                return new()
                {
                    IsSucceed = true,
                    Token = token,
                    UserRoles = (await _userManager.GetRolesAsync(user)).ToList()
                };
            }
            return new()
            {
                IsSucceed = false,
                Message = "Kimlik doğrulama hatası"
            };
        }

        public async Task<Token> RefreshTokenLogin(string refreshTokenLoginRequest)
        {
            e.FinanceAppUser? user = await _userManager.Users.FirstOrDefaultAsync(x => x.RefreshToken == refreshTokenLoginRequest);
            if (user != null && user.RefreshTokenEndDate > DateTime.UtcNow)
            {
                Token token = await _tokenHandler.GenerateAccessTokenAsync(1, user);
                await _appUserService.UpdateRefreshToken(token.RefreshToken, user, token.Expiration, 1);
                return token;
            }
            else
                throw new Exception("Token üretilemedi");
        }
    }
}
