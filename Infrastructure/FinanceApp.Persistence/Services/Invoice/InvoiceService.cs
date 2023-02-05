using AutoMapper;
using FinanceApp.Application.Abstruction.Services.Invoice;
using FinanceApp.Application.Features.Invoice.Commands;
using FinanceApp.Application.Repositories.Invoice;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Services.Invoice
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceWriteRepository _invoiceWriteRepository;
        private readonly IInvoiceReadRepository _invoiceReadRepository;

        private readonly IMapper _mapper;
        public InvoiceService(IInvoiceWriteRepository invoiceWriteRepository, IMapper mapper, IInvoiceReadRepository invoiceReadRepository)
        {
            _invoiceWriteRepository = invoiceWriteRepository;
            _mapper = mapper;
            _invoiceReadRepository = invoiceReadRepository;
        }

        public List<e.Invoice> GetAllInvoicesByBuyer(Guid buyerId)
        {
            return _invoiceReadRepository.GetWhere(x => x.BuyerId == buyerId).ToList();
        }

        public List<e.Invoice> GetAllInvoicesBySupplier(Guid supplierId)
        {
            return _invoiceReadRepository.GetWhere(x => x.SupplierId == supplierId).ToList();
        }

        public async Task<Guid> UploadInvoiceAsync(UploadInvoiceCommandRequest invoice)
        {
            var result = await _invoiceWriteRepository.SaveAsync(_mapper.Map<e.Invoice>(invoice));
            await _invoiceWriteRepository.SaveAsync();
            return result;

        }
    }
}
