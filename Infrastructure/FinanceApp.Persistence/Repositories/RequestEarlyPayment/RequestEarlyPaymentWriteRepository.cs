using FinanceApp.Application.Repositories.RequestEarlyPayment;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Repositories.RequestEarlyPayment
{
    public class RequestEarlyPaymentWriteRepository : WriteRepository<e.RequestEarlyPayment>, IRequestEarlyPaymentWriteRepository
    {
        public RequestEarlyPaymentWriteRepository(FinanceAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
