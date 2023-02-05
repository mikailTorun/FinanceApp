using FinanceApp.Domain.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Application.Features.FinanceAppUser.Commands
{
    public class CreateFinanceAppUserCommandRequest : IRequest<CreateFinanceAppUserCommandResponse>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string? Password{ get; set; }
        public string Role { get; set; }
        public Guid? BuyerId { get; set; }
        public virtual e.Buyer? Buyer { get; set; }
        public Guid? SupplierId { get; set; }
        public virtual e.Supplier? Supplier { get; set; }
        public Guid? FinancialInstitutionId { get; set; }
        public virtual e.FinancialInstitution? FinancialInstitution { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
    }
}
