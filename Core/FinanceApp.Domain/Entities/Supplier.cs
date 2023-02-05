using FinanceApp.Domain.Entities.Common;
using System.Collections.ObjectModel;

namespace FinanceApp.Domain.Entities
{
    public class Supplier : FinanceAppBaseEntity
    {
        public Supplier()
        {
            this.Invoices = new Collection<Invoice>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string TaxId { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
