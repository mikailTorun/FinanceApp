using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceApp.Domain.Entities.Common
{
    public class FinanceAppUser : IdentityUser<Guid>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        [NotMapped]
        public string Fullname { get => Name + " " + Surname; }
        public Guid? SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public Guid? BuyerId { get; set; }
        public virtual Buyer? Buyer { get; set; }
        public Guid? FinancialInstitutionId { get; set; }
        public virtual FinancialInstitution? FinancialInstitution { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
    }
}
