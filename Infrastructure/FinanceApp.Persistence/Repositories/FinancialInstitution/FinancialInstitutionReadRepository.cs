using FinanceApp.Application.Repositories.FinancialInstitution;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;

namespace FinanceApp.Persistence.Repositories.FinancialInstitution
{
    public class FinancialInstitutionReadRepository : ReadRepository<e.FinancialInstitution>, IFinancialInstitutionReadRepository
    {
        public FinancialInstitutionReadRepository(FinanceAppDbContext financeAppDbContext) : base(financeAppDbContext)
        {
        }
    }
}
