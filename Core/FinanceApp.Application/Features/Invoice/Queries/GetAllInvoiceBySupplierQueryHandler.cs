using FinanceApp.Application.Abstruction.Services.Invoice;
using FinanceApp.Application.Repositories.Invoice;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Application.Features.Invoice.Queries
{
    public class GetAllInvoiceBySupplierQueryHandler : IRequestHandler<GetAllInvoiceBySupplierQueryRequest, GetAllInvoiceBySupplierQueryResponse>
    {
        private readonly IInvoiceService _invoiceService;

        public GetAllInvoiceBySupplierQueryHandler(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public async Task<GetAllInvoiceBySupplierQueryResponse> Handle(GetAllInvoiceBySupplierQueryRequest request, CancellationToken cancellationToken)
        {

            var result = await Task.Run(() =>
            {
                return _invoiceService.GetAllInvoicesBySupplier(request.SupplierId);
            });
            return new() { Invoices = result };
        }
    }
}
