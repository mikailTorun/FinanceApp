using FinanceApp.Domain.Entities.Common;
using FinanceApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Domain.Entities
{
    public class Invoice : FinanceAppBaseEntity
    {
        [Required]
        public string InvoiceNumber { get; set; }
        public DateTime TermDate { get; set; }
        [Required]
        public Guid BuyerId { get; set; }
        public virtual Buyer Buyer { get; set; }
        [Required]
        public Guid SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public decimal InvoiceCost { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }
    }
}
