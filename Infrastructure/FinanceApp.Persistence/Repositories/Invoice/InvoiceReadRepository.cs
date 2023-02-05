using FinanceApp.Application.Repositories.Invoice;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Repositories.Invoice
{
    public class InvoiceReadRepository : ReadRepository<e.Invoice>, IInvoiceReadRepository
    {
        public InvoiceReadRepository(FinanceAppDbContext financeAppDbContext) : base(financeAppDbContext)
        {
        }
    }
}
