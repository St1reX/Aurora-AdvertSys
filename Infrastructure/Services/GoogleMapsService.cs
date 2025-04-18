﻿using Application.Services;
using Application.Shared.Address.DTOs;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace Infrastructure.Services
{
    public class GoogleMapsService : ILocationService
    {
        private readonly HttpClient httpClient;
        private readonly string _apiKey;
        private readonly string _geocodeUrl = "https://maps.googleapis.com/maps/api/geocode/json";

        public GoogleMapsService(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            _apiKey = configuration["GoogleApi:ApiKey"]!;
        }
            
        public async Task<AddressDTO?> GetCoordinatesAsync(string address)
        {
            //REQUEST TO GOOGLE MAPS API
            var uriBuilder = new UriBuilder(_geocodeUrl)
            {
                Query = $"address={Uri.EscapeDataString($"{address}")}&language=en&key={_apiKey}"
            };

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_geocodeUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(uriBuilder.Uri);

            //RESPONSE HANDLING
            if (response.IsSuccessStatusCode)
            {
                JObject jsonResponse = JObject.Parse(await response.Content.ReadAsStringAsync());
                var results = jsonResponse["results"];

                if (results != null && results.HasValues)
                {
                    var adressData = results?[0]?["address_components"];
                    var coordinates = results?[0]?["geometry"]?["location"];

                    var adressDTO = new AddressDTO
                    {
                        StreetNumber = adressData!.FirstOrDefault(x => x["types"]!.Any(y => y.ToString() == "street_number" || y.ToString() == "premise"))?["long_name"]?.ToString(),
                        Street = adressData!.FirstOrDefault(x => x["types"]!.Any(y => y.ToString() == "route"))?["long_name"]?.ToString(),
                        City = adressData!.FirstOrDefault(x => x["types"]!.Any(y => y.ToString() == "locality"))?["long_name"]?.ToString(),
                        Region = adressData!.FirstOrDefault(x => x["types"]!.Any(y => y.ToString() == "administrative_area_level_1"))?["long_name"]?.ToString(),
                        Country = adressData!.FirstOrDefault(x => x["types"]!.Any(y => y.ToString() == "country"))!["long_name"]!.ToString(),
                        Latitude = Convert.ToDecimal(coordinates?["lat"]!),
                        Longitude = Convert.ToDecimal(coordinates?["lng"]!),
                    };

                    return adressDTO;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
