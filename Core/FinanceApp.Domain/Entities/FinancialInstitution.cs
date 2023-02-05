using FinanceApp.Domain.Entities.Common;

namespace FinanceApp.Domain.Entities
{
    public class FinancialInstitution : FinanceAppBaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string TaxId { get; set; }
    }
}
