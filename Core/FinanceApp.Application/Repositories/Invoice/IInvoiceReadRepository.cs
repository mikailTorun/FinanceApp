using entity = FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Repositories.Invoice
{
    public interface IInvoiceReadRepository : IReadRepository<entity.Invoice>
    {
    }
}
