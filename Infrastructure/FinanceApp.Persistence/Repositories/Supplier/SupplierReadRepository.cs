using FinanceApp.Application.Repositories.Supplier;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Repositories.Supplier
{
    public class SupplierReadRepository : ReadRepository<e.Supplier>, ISupplierReadRepository
    {
        public SupplierReadRepository(FinanceAppDbContext financeAppDbContext) : base(financeAppDbContext)
        {
        }
    }
}