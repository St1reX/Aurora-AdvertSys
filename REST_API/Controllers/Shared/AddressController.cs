using Application.Shared.Address.Commands;
using MediatR;
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

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
