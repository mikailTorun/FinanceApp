using AutoMapper;
using FinanceApp.Application.Abstruction.Services.Buyer;
using FinanceApp.Application.Features.Buyer.Commands;
using FinanceApp.Application.Repositories.Buyer;
using e = FinanceApp.Domain.Entities;

namespace FinanceApp.Persistence.Services.Buyer
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerWriteRepository _buyerWriteRepository;
        private readonly IMapper _mapper;
        public BuyerService(IBuyerWriteRepository buyerWriteRepository, IMapper mapper)
        {
            this._buyerWriteRepository = buyerWriteRepository;
            this._mapper = mapper;
        }

        public async Task<CreateBuyerCommandResponse> CreateBuyerAsync(CreateBuyerCommandRequest createBuyerRequest)
        {
            var savedBuyer = await this._buyerWriteRepository.AddAsync(this._mapper.Map<e.Buyer>(createBuyerRequest));
            await _buyerWriteRepository.SaveAsync();
            return new() { IsSucceed = savedBuyer };
        }
    }
}
