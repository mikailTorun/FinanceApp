using FinanceApp.Application.Features.Invoice.Commands;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InvoiceController : ControllerBase
    {
        private readonly IMediator _mediatr;
        public InvoiceController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }
        [HttpPost]
        public Task<UploadInvoiceCommandResponse> UploadInvoiceAsync(UploadInvoiceCommandRequest invoice)
        {
            return _mediatr.Send(invoice);
        }
    }
}
