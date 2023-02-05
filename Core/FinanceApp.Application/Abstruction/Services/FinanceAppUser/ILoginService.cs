using FinanceApp.Application.Features.FinanceAppUser.Commands;

namespace FinanceApp.Application.Abstruction.Services.FinanceAppUser
{
    public interface ILoginService
    {
        Task<LoginUserResponse> Login(LoginUserRequest loginRequest);
        Task<FinanceApp.Application.Models.Token> RefreshTokenLogin(string refreshTokenLoginRequest);
    }
}
