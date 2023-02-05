using AutoMapper;
using FinanceApp.Application.Abstruction.Services.Supplier;
using FinanceApp.Application.Features.Supplier.Commands;
using FinanceApp.Application.Repositories.Supplier;
using System.Runtime.Versioning;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Services.Supplier
{
    public class SupplierService : ISupplierService
    {
        private readonly IMapper _mapper;
        private readonly ISupplierWriteRepository _supplierWriteRepository;
        public SupplierService(ISupplierWriteRepository supplierWriteRepository, IMapper mapper)
        {
            _supplierWriteRepository = supplierWriteRepository;
            _mapper = mapper;
        }

        public Task<Guid> CreateSupplierAsync(CreateSupplierCommandRequest supplier)
        {
            e.Supplier data = _mapper.Map<e.Supplier>(supplier);
            data.Id = Guid.NewGuid();
            var save = _supplierWriteRepository.SaveAsync(data);
            _supplierWriteRepository.SaveAsync();
            return save;
        }
    }
}
