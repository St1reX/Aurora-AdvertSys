using Application.Shared.Address.Commands;
using Application.Shared.Company.Queries.GetAllCompanies;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers.Shared
{
    [Route("api/address")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IMediator mediator;

        public AddressController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<AddressController>
        [HttpPost]
        public async Task<IActionResult> SaveAddress(SaveAdressCommand command)
        {
            try
            {
                await mediator.Send(command);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
