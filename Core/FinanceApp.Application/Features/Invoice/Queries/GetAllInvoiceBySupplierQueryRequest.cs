using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Application.Features.Invoice.Queries
{
    public class GetAllInvoiceBySupplierQueryRequest : IRequest<GetAllInvoiceBySupplierQueryResponse>
    {
        public Guid SupplierId { get; set; }
    }
}
