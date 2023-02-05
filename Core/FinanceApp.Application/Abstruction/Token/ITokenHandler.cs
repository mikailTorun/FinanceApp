using FinanceApp.Domain.Entities.Common;
using model = FinanceApp.Application.Models;

namespace FinanceApp.Application.Abstruction.Token
{
    public interface ITokenHandler
    {
        Task<model.Token> GenerateAccessTokenAsync(int min, FinanceAppUser user);
        string GenerateRefreshToken();
    }
}
