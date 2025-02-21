using Application.ContractType.Queries.GetAllContractTypes;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers
{
    [Route("api/contract-type")]
    [ApiController]
    public class ContractTypeController : ControllerBase
    {
        private readonly IMediator mediator;

        public ContractTypeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<WorkModelController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contractTypes = await mediator.Send(new GetAllContractTypesQuery());
            return Ok(JsonSerializer.Serialize(contractTypes));
        }
    }
}
