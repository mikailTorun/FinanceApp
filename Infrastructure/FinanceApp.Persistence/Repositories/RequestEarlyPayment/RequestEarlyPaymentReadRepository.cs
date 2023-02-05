using FinanceApp.Application.Repositories.RequestEarlyPayment;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Repositories.RequestEarlyPayment
{
    public class RequestEarlyPaymentReadRepository : ReadRepository<e.RequestEarlyPayment>, IRequestEarlyPaymentReadRepository
    {
        public RequestEarlyPaymentReadRepository(FinanceAppDbContext financeAppDbContext) : base(financeAppDbContext)
        {
        }
    }
}
