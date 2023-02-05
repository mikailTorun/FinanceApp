using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Application.Features.Invoice.Queries
{
    public class GetAllInvoiceBySupplierQueryResponse
    {
        public List<e.Invoice> Invoices { get; set; } 
    }
}
