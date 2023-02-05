using FinanceApp.Application.Models;

namespace FinanceApp.Application.Features.FinanceAppUser.Commands
{
    public class LoginUserResponse
    {
        public bool IsSucceed { get; set; }
        public string Message { get; set; }
        public Token Token { get; set; }
        public List<string>? UserRoles { get; set; }
    }
}
