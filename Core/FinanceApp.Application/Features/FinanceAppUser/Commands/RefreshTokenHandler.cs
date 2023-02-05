using FinanceApp.Application.Abstruction.Services.FinanceAppUser;
using FinanceApp.Application.Models;
using MediatR;

namespace FinanceApp.Application.Features.FinanceAppUser.Commands
{
    public class RefreshTokenHandler : IRequestHandler<RefreshTokenRequest, RefreshTokenResponse>
    {
        private readonly ILoginService _loginService;

        public RefreshTokenHandler(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public async Task<RefreshTokenResponse> Handle(RefreshTokenRequest request, CancellationToken cancellationToken)
        {
            Token token = await _loginService.RefreshTokenLogin(request.RefreshToken);
            return new() { Token = token };
        }
    }
}
