using Application.Shared.Position.Queries.GetAllPositions;
using Application.Shared.Position.Queries.GetPositionsAutocomplete;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers.Shared
{
    [Route("api/position")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IMediator mediator;

        public PositionController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<PositionController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var positions = await mediator.Send(new GetAllPositionsQuery());
            return Ok(JsonSerializer.Serialize(positions));
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetRowsToAutocomplete(string? positionName)
        {
            var positions = await mediator.Send(new GetPositionsAutocompleteQuery { PositionName = positionName });
            return Ok(JsonSerializer.Serialize(positions));
        }

    }
}
