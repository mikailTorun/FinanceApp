using MediatR;

namespace FinanceApp.Application.Features.FinanceAppUser.Commands
{
    public class RefreshTokenRequest : IRequest<RefreshTokenResponse>
    {
        public string RefreshToken { get; set; }
    }
}
