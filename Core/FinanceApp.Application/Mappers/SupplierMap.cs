using AutoMapper;
using FinanceApp.Application.Features.Supplier.Commands;
using FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Mappers
{
    public class SupplierMap : Profile
    {
        public SupplierMap()
        {
            CreateMap<Supplier, CreateSupplierCommandRequest>().ReverseMap();
        }
    }
}
