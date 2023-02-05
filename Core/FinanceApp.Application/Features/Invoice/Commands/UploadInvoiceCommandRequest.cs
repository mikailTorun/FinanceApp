using FinanceApp.Domain.Entities;
using FinanceApp.Domain.Enums;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Application.Features.Invoice.Commands
{
    public class UploadInvoiceCommandRequest : IRequest<UploadInvoiceCommandResponse>
    {
        public string InvoiceNumber { get; set; }
        public DateTime TermDate { get; set; }
        public decimal InvoiceCost { get; set; }
        public Guid BuyerId { get; set; }
        public Guid SupplierId { get; set; }
    }
}
