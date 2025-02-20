using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
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
            return Ok();
        }
    }
}
