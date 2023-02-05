using FinanceApp.Application.Abstruction.Services.FinancialInstitutionService;
using MediatR;

namespace FinanceApp.Application.Features.FinancialInstitution.Commands
{
    public class CreateFinancialInstitutionCommandHandler : IRequestHandler<CreateFinancialInstitutionCommandRequest, CreateFinancialInstitutionCommandResponse>
    {
        private readonly IFinancialInstitutionService _financialInstitutionService;

        public CreateFinancialInstitutionCommandHandler(IFinancialInstitutionService financialInstitutionService)
        {
            _financialInstitutionService = financialInstitutionService;
        }

        public async Task<CreateFinancialInstitutionCommandResponse> Handle(CreateFinancialInstitutionCommandRequest request, CancellationToken cancellationToken)
        {
            var Id = await _financialInstitutionService.CreateFinancialInstitution(request);
            return new() { Id=Id};
        }
    }
}
