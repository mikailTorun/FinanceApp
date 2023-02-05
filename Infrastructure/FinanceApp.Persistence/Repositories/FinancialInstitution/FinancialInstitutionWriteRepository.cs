namespace FinanceApp.Persistence.Repositories.FinancialInstitution
{
    using FinanceApp.Application.Repositories.FinancialInstitution;
    using FinanceApp.Domain.Entities;
    using FinanceApp.Persistence.Contexts;
    public class FinancialInstitutionWriteRepository : WriteRepository<FinancialInstitution>, IFinancialInstitutionWriteRepository
    {
        public FinancialInstitutionWriteRepository(FinanceAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
