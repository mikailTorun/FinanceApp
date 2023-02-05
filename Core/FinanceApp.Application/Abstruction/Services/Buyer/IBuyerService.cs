using FinanceApp.Application.Features.Buyer.Commands;

namespace FinanceApp.Application.Abstruction.Services.Buyer
{
    public interface IBuyerService
    {
        //GetAllCustomerQueryResponse GetAll();
        Task<CreateBuyerCommandResponse> CreateBuyerAsync(CreateBuyerCommandRequest createCustomerRequest);
    }
}
