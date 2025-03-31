using Application.AdvertDependent.EmploymentType.Queries.GetAllEmploymentTypes;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers.AdvertDependent
{
    [Route("api/employment-type")]
    [ApiController]
    public class EmploymentTypeController : ControllerBase
    {
        private readonly IMediator mediator;

        public EmploymentTypeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<WorkModelController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employmentTypes = await mediator.Send(new GetAllEmploymentTypesQuery());
            return Ok(employmentTypes);
        }
    }
}
