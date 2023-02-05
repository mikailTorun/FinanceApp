using FinanceApp.Application.Abstruction.Services.FinanceAppUser;
using FinanceApp.Application.Abstruction.Services.Invoice;
using FinanceApp.Application.Models;
using MediatR;

namespace FinanceApp.Application.Features.Invoice.Commands
{
    public class UploadInvoiceCommandHandler : IRequestHandler<UploadInvoiceCommandRequest, UploadInvoiceCommandResponse>
    {
        private readonly IInvoiceService _invoiceService;

        public UploadInvoiceCommandHandler(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public async Task<UploadInvoiceCommandResponse> Handle(UploadInvoiceCommandRequest request, CancellationToken cancellationToken)
        {
            var id = await _invoiceService.UploadInvoiceAsync(request);
            return new() { Id = id };
        }
    }
}
