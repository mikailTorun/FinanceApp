using FinanceApp.Application.Constants;
using FinanceApp.Application.Features.FinanceAppUser.Commands;
using FinanceApp.Application.Features.FinancialInstitution.Commands;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Roles = FinanceAppUserRole.FinancialInstitution)]
    public class FinancialInstitutionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FinancialInstitutionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CreateFinancialInstitutionAsync")]
        public async Task<CreateFinancialInstitutionCommandResponse> CreateBuyerAsync(CreateFinancialInstitutionCommandRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost]
        [Route("CreateFinancialInstitutionUserAsync")]
        public async Task<CreateFinanceAppUserCommandResponse> CreateFinancialInstitutionUserAsync(CreateFinanceAppUserCommandRequest user)
        {
            user.Role = FinanceAppUserRole.FinancialInstitution;
            return await _mediator.Send(user);
        }
    }
}
