using Application.AdvertDependent.Advert.Queries.GetAdvertDetails;
using Application.AdvertDependent.Advert.Queries.GetAllAdverts;
using Application.AdvertDependent.Advert.Queries.GetFilteredAdverts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//TODO: basic GET endpoints for entities that can be accessed by anyone without authentication

namespace REST_API.Controllers.AdvertDependent
{
    [Route("api/adverts")]
    [ApiController]
    public class AdvertController : Controller
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

            return Ok(adverts);
        }


        [HttpGet("filter")]
        public async Task<IActionResult> GetFiltered([FromQuery] GetFilteredAdvertsQuery command)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var adverts = await mediator.Send(command);

            return Ok(adverts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var advertDetails = await mediator.Send(new GetAdvertDetailsQuery { AdvertID = id });

            if (advertDetails == null)
            {
                return NotFound();
            }

            return Ok(advertDetails);
        }
    }
}
