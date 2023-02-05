using FinanceApp.Application.Abstruction.Services.Supplier;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Application.Features.Supplier.Commands
{
    public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommandRequest, CreateSupplierCommandResponse>
    {
        private readonly ISupplierService _supplierService;

        public CreateSupplierCommandHandler(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public async Task<CreateSupplierCommandResponse> Handle(CreateSupplierCommandRequest request, CancellationToken cancellationToken)
        {
            var id = await _supplierService.CreateSupplierAsync(request);
            return new() { Id = id };
        }
    }
}
