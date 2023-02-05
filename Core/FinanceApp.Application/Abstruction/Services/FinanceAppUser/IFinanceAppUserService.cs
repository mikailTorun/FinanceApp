using FinanceApp.Application.Features.FinanceAppUser.Commands;
using e = FinanceApp.Domain.Entities.Common;
namespace FinanceApp.Application.Abstruction.Services.FinanceAppUser
{
    public interface IFinanceAppUserService
    {
        Task<CreateFinanceAppUserCommandResponse> CreateUserAsync(CreateFinanceAppUserCommandRequest userRequest);
        Task UpdateRefreshToken(string refreshToken, e.FinanceAppUser user, DateTime accessTokenLifeTime, int refreshTokenTime);
    }
}
