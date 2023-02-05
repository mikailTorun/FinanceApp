using entity = FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Repositories.Invoice
{
    public interface IInvoiceWriteRepository : IWriteRepository<entity.Invoice>
    {
    }
}
