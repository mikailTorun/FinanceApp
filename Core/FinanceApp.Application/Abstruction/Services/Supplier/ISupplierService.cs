using FinanceApp.Application.Features.Supplier.Commands;

namespace FinanceApp.Application.Abstruction.Services.Supplier
{
    public interface ISupplierService
    {
        Task<Guid> CreateSupplierAsync(CreateSupplierCommandRequest supplier);
    }
}
