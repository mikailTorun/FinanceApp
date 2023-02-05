using FinanceApp.Application.Constants;
using FinanceApp.Application.Features.Buyer.Commands;
using FinanceApp.Application.Features.FinanceAppUser.Commands;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Roles = FinanceAppUserRole.Buyer)]
    public class BuyerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BuyerController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        [Route("CreateBuyerAsync")]
        public async Task<CreateBuyerCommandResponse> CreateBuyerAsync(CreateBuyerCommandRequest buyer)
        {
            return await _mediator.Send(buyer);
        }
        [HttpPost]
        [Route("CreateBuyerUserAsync")]
        public async Task<CreateFinanceAppUserCommandResponse> CreateBuyerUserAsync(CreateFinanceAppUserCommandRequest user)
        {
            user.Role = FinanceAppUserRole.Buyer;
            return await _mediator.Send(user);
        }
    }
}
