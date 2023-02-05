using FinanceApp.Application.Features.Invoice.Commands;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Application.Abstruction.Services.Invoice
{
    public interface IInvoiceService
    {
        Task<Guid> UploadInvoiceAsync(UploadInvoiceCommandRequest invoice);
        List<e.Invoice> GetAllInvoicesBySupplier(Guid supplierId);
        List<e.Invoice> GetAllInvoicesByBuyer(Guid buyerId);
    }
}
