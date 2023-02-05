using FinanceApp.Application.Constants;
using FinanceApp.Application.Features.FinanceAppUser.Commands;
using FinanceApp.Application.Features.Invoice.Queries;
using FinanceApp.Application.Features.Supplier.Commands;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Roles = FinanceAppUserRole.Supplier)]
    public class SupplierController : ControllerBase
    {
        private IMediator _mediator;

        public SupplierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CreateSupplierUserAsync")]
        public async Task<CreateFinanceAppUserCommandResponse> CreateSupplierUserAsync(CreateFinanceAppUserCommandRequest user)
        {
            user.Role = FinanceAppUserRole.Supplier;
            return await _mediator.Send(user);
        }

        [HttpPost]
        [Route("CreateSupplierAsync")]
        public async Task<CreateSupplierCommandResponse> CreateSupplierAsync(CreateSupplierCommandRequest supplier)
        {
            return await _mediator.Send(supplier);
        }
        [HttpGet]
        [Route("GetAllSelfInvoicesAsync")]
        public async Task<GetAllInvoiceBySupplierQueryResponse> GetAllSelfInvoicesAsync([FromQuery]Guid supplierId)
        {
            GetAllInvoiceBySupplierQueryRequest request = new() {SupplierId=supplierId };
            return await _mediator.Send(request);
        }
    }
}
