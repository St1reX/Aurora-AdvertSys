using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Company.Queries.GetAllCompanies;
using System.Text.Json;
using Application.Company.Queries.GetCompanyDetails;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator mediator;

        public CompanyController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var companies = await mediator.Send(new GetAllCompaniesQuery());
            return Ok(JsonSerializer.Serialize(companies));
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var company = await mediator.Send(new GetCompanyDetailsQuery { CompanyID = id});
            return Ok(JsonSerializer.Serialize(company));
        }

        // POST api/<CompanyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
