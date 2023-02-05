using FinanceApp.Application.Repositories.Invoice;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;

namespace FinanceApp.Persistence.Repositories.Invoice
{
    public class InvoiceWriteRepository : WriteRepository<e.Invoice>, IInvoiceWriteRepository
    {
        public InvoiceWriteRepository(FinanceAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
