using AutoMapper;
using FinanceApp.Application.Features.Invoice.Commands;
using FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Mappers
{
    public class InvoiceMap : Profile
    {
        public InvoiceMap()
        {
            CreateMap<Invoice, UploadInvoiceCommandRequest>().ReverseMap();
        }
    }
}
