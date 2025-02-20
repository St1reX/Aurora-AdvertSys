using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Company.Queries.GetAllCompanies;
using System.Text.Json;
using Application.Company.Queries.GetCompanyDetails;
using Application.Company.Queries.GetCompaniesAutocomplete;

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

            if(company == null)
            {
                return NotFound();
            }

            return Ok(JsonSerializer.Serialize(company));
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetRowsToAutocomplete(string? companyName)
        {
            var companies = await mediator.Send(new GetCompaniesAutocompleteQuery { CompanyName = companyName });
            return Ok(JsonSerializer.Serialize(companies));
        }

       
    }
}
