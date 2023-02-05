using FinanceApp.Application.Repositories.Buyer;
using FinanceApp.Domain.Entities;
using FinanceApp.Persistence.Contexts;

namespace FinanceApp.Persistence.Repositories
{

    public class BuyerWriteRepository : WriteRepository<Buyer>, IBuyerWriteRepository
    {
        public BuyerWriteRepository(FinanceAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
