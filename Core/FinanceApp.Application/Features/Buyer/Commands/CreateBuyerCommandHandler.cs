using FinanceApp.Application.Abstruction.Services.Buyer;
using MediatR;

namespace FinanceApp.Application.Features.Buyer.Commands
{
    public class CreateBuyerCommandHandler : IRequestHandler<CreateBuyerCommandRequest, CreateBuyerCommandResponse>
    {
        private readonly IBuyerService _buyerService;

        public CreateBuyerCommandHandler(IBuyerService buyerService)
        {
            this._buyerService = buyerService;
        }

        public async Task<CreateBuyerCommandResponse> Handle(CreateBuyerCommandRequest request, CancellationToken cancellationToken)
        {
            return await _buyerService.CreateBuyerAsync(request);
        }
    }
}
