using FinanceApp.Application.Repositories.Buyer;
using FinanceApp.Domain.Entities;
using FinanceApp.Persistence.Contexts;

namespace FinanceApp.Persistence.Repositories
{
    public class BuyerReadRepository : ReadRepository<Buyer>, IBuyerReadRepository
    {
        public BuyerReadRepository(FinanceAppDbContext context) : base(context)
        {
        }
    }
}
