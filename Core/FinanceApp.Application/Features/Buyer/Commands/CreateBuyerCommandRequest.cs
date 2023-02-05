using MediatR;

namespace FinanceApp.Application.Features.Buyer.Commands
{
    public class CreateBuyerCommandRequest : IRequest<CreateBuyerCommandResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string TaxId { get; set; }
    }
}
