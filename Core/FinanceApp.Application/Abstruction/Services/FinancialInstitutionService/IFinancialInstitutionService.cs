using FinanceApp.Application.Features.FinancialInstitution.Commands;

namespace FinanceApp.Application.Abstruction.Services.FinancialInstitutionService
{
    public interface IFinancialInstitutionService
    {
        Task<Guid> CreateFinancialInstitution(CreateFinancialInstitutionCommandRequest request);
    }
}
