using FinanceApp.Application.Abstruction.Services.FinanceAppUser;
using MediatR;
namespace FinanceApp.Application.Features.FinanceAppUser.Commands
{
    public class LoginUserHandler : IRequestHandler<LoginUserRequest, LoginUserResponse>
    {
        private readonly ILoginService _loginService;

        public LoginUserHandler(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public async Task<LoginUserResponse> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {
            return await _loginService.Login(request);
        }
    }
}
