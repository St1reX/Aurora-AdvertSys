using Application.Advert.Queries.GetAdvertDetails;
using Application.Advert.Queries.GetAllAdverts;
using Application.Advert.Queries.GetFilteredAdverts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//TODO: basic GET endpoints for entities that can be accessed by anyone without authentication

namespace REST_API.Controllers
{
    [Route("api/advert")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public AdvertController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var adverts = await mediator.Send(new GetAllAdvertsQuery());

            return Ok(JsonSerializer.Serialize(adverts));
        }


        [HttpGet("filter")]
        public async Task<IActionResult> GetFiltered([FromQuery] GetFilteredAdvertsQuery command)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var adverts = await mediator.Send(command);

            return Ok(JsonSerializer.Serialize(adverts));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var advertDetails = await mediator.Send(new GetAdvertDetailsQuery { Id = id });

            if (advertDetails == null)
            {
                return NotFound();
            }

            return Ok(JsonSerializer.Serialize(advertDetails));
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
