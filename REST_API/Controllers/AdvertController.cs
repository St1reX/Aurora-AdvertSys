﻿using Application.Advert.Queries.GetAllAdverts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        public async Task<IActionResult> GetFiltered(
            [FromQuery] int? amount, 
            [FromQuery] int? offset,
            [FromQuery] bool? cvMandatory,
            [FromQuery] string? companyName, 
            [FromQuery] string? positionName,
            [FromQuery] string? seniorityLevelName,
            [FromQuery] decimal? minSalary,
            [FromQuery] decimal? maxSalary
            )
        {
            //TODO: Implement filtering by location(API) and convert system to DTO filtering model
            return Ok();
        }




        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
