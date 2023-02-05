using AutoMapper;
using FinanceApp.Application.Features.FinancialInstitution.Commands;
using FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Mappers
{
    public class FinancialInstitutionMap : Profile
    {
        public FinancialInstitutionMap()
        {
            CreateMap<FinancialInstitution, CreateFinancialInstitutionCommandRequest>().ReverseMap();
        }
    }
}
