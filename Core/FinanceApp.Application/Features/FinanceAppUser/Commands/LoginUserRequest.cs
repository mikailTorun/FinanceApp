using MediatR;

namespace FinanceApp.Application.Features.FinanceAppUser.Commands
{
    public class LoginUserRequest : IRequest<LoginUserResponse>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
