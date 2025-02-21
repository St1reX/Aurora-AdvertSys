using Application.JobSector.Queries.GetAllJobSectors;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers
{
    [Route("api/job-sector")]
    [ApiController]
    public class JobSectorController : ControllerBase
    {
        private readonly IMediator mediator;

        public JobSectorController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<WorkModelController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var jobSectors = await mediator.Send(new GetAllJobSectorsQuery());

            return Ok(JsonSerializer.Serialize(jobSectors));
        }
    }
}
