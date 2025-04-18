﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Shared.Company.Queries.GetAllCompanies;
using System.Text.Json;
using Application.Shared.Company.Queries.GetCompanyDetails;
using Application.Shared.Company.Queries.GetCompaniesAutocomplete;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API.Controllers.Shared
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController : Controller
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
            return Ok(companies);
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

            return Ok(company);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetRowsToAutocomplete(string? companyName)
        {
            var companies = await mediator.Send(new GetCompaniesAutocompleteQuery { CompanyName = companyName });
            return Ok(companies);
        }
    }
}
