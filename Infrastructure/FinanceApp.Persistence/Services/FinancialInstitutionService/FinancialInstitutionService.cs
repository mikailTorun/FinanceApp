using AutoMapper;
using FinanceApp.Application.Abstruction.Services.FinancialInstitutionService;
using FinanceApp.Application.Features.FinancialInstitution.Commands;
using FinanceApp.Application.Repositories.FinancialInstitution;
using FinanceApp.Domain.Entities;

namespace FinanceApp.Persistence.Services.FinancialInstitutionService
{
    public class FinancialInstitutionService : IFinancialInstitutionService
    {
        private readonly IFinancialInstitutionWriteRepository _financialInstitutionWriteRepository;
        private readonly IMapper _mapper;
        public FinancialInstitutionService(IFinancialInstitutionWriteRepository financialInstitutionWriteRepository, IMapper mapper)
        {
            _financialInstitutionWriteRepository = financialInstitutionWriteRepository;
            _mapper = mapper;
        }

        public async Task<Guid> CreateFinancialInstitution(CreateFinancialInstitutionCommandRequest request)
        {
            var Id =  await _financialInstitutionWriteRepository.SaveAsync(_mapper.Map<FinancialInstitution>(request));
            await _financialInstitutionWriteRepository.SaveAsync();
            return Id;
        }
    }
}
