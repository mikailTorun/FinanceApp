using FinanceApp.Application.Repositories.Supplier;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Repositories.Supplier
{
    public class SupplierWriteRepository : WriteRepository<e.Supplier>, ISupplierWriteRepository
    {
        public SupplierWriteRepository(FinanceAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
