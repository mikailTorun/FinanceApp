using AutoMapper;
using FinanceApp.Application.Features.FinanceAppUser.Commands;
using FinanceApp.Domain.Entities.Common;

namespace FinanceApp.Application.Mappers
{
    public class FinanceAppUserMap : Profile
    {
        public FinanceAppUserMap()
        {
            CreateMap<FinanceAppUser, CreateFinanceAppUserCommandRequest>().ReverseMap();
        }
    }
}
