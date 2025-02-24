using Application.AdvertDependent.SeniorityLevel.Queries.GetAllSeniorityLevels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers.AdvertDependent
{
    [Route("api/seniority-level")]
    [ApiController]
    public class SeniorityLevelController : ControllerBase
    {
        private readonly IMediator mediator;

        public SeniorityLevelController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<WorkModelController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var seniorityLevels = await mediator.Send(new GetAllSeniorityLevelsQuery());
            return Ok(JsonSerializer.Serialize(seniorityLevels));
        }
    }
}
