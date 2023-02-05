using FinanceApp.Application.Abstruction.Services.FinanceAppUser;
using FinanceApp.Application.Constants;
using MediatR;

namespace FinanceApp.Application.Features.FinanceAppUser.Commands
{
    public class CreateFinanceAppUserCommandHandler : IRequestHandler<CreateFinanceAppUserCommandRequest, CreateFinanceAppUserCommandResponse>
    {
        private readonly IFinanceAppUserService _financeAppUserService;
        public CreateFinanceAppUserCommandHandler(IFinanceAppUserService financeAppUserService)
        {
            this._financeAppUserService = financeAppUserService;
        }
        public async Task<CreateFinanceAppUserCommandResponse> Handle(CreateFinanceAppUserCommandRequest request, CancellationToken cancellationToken)
        {
            return await this._financeAppUserService.CreateUserAsync(request);
        }
    }
}
