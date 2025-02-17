using Application.Services;
using Core.Entities.UserDependent;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GoogleMapsService : ILocationService
    {
        private readonly HttpClient httpClient;
        private readonly string _apiKey;

        public GoogleMapsService(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            _apiKey = configuration["GoogleApi:ApiKey"]!;
        }

        public Task<FilteredLocationsCache> GetCoordinates()
        {
            
        }
    }
}
