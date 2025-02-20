using Application.WorkModel.Queries.GetAllWorkModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers
{
    [Route("api/work-model")]
    [ApiController]
    public class WorkModelController : ControllerBase
    {
        private readonly IMediator mediator;

        public WorkModelController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<WorkModelController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var workModels = await mediator.Send(new GetAllWorkModelsQuery());
            return Ok(JsonSerializer.Serialize(workModels));
        }
    }
}
