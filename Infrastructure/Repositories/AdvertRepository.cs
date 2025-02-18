using Application.Services;
using Core.Entities;
using Core.Helpers;
using Core.Interfaces;
using Core.Utilities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class AdvertRepository : IAdvert
    {
        private readonly AuroraDbContext dbContext;
        private readonly ILocationService locationService;
        private readonly ICachedAddress cachedAddress;

        public AdvertRepository(AuroraDbContext dbContext, ILocationService locationService, ICachedAddress cachedAddress)
        {
            this.dbContext = dbContext;
            this.locationService = locationService;
            this.cachedAddress = cachedAddress;
        }

        public async Task<ICollection<Advert>?> GetAll()
        {
            var adverts = await dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .ToListAsync();

            return adverts;
        }

        public async Task<ICollection<Advert>?> GetFiltered(AdvertFilter advertFilter)
        {
            var filterQuery = dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .Include(x => x.AdvertAddress)
                .AsQueryable();

            if(advertFilter.CompanyID != null)
            {
                filterQuery = filterQuery.Where(x => x.CompanyID == advertFilter.CompanyID);
            }

            if (advertFilter.PositionID != null)
            {
                filterQuery = filterQuery.Where(x => x.PositionID == advertFilter.PositionID);
            }

            if (advertFilter.SeniorityLevelID != null)
            {
                filterQuery = filterQuery.Where(x => x.SeniorityLevelID == advertFilter.SeniorityLevelID);
            }

            if(advertFilter.MinSalary != null)
            {
                filterQuery = filterQuery.Where(x => x.MinSalary >= advertFilter.MinSalary);
            }

            if(advertFilter.MaxSalary != null)
            {
                filterQuery = filterQuery.Where(x => x.MaxSalary <= advertFilter.MaxSalary);
            }

            if (advertFilter.CVMandatory != null)
            {
               filterQuery = filterQuery.Where(x => x.CVMandatory == advertFilter.CVMandatory);
            }

            var queryFilteredAdverts = await filterQuery
                .ToListAsync();

            var locationFilteredAdverts = new List<Advert>();


            if(advertFilter.Location != null && advertFilter.AcceptableDistance != null)
            {
                var userPromptAddress = await locationService.GetCoordinatesAsync(advertFilter.Location);

                if (userPromptAddress != null)
                {
                    Console.WriteLine(userPromptAddress.Latitude + " " + userPromptAddress.Longitude);

                    foreach (var advert in queryFilteredAdverts)
                    {
                        var advertAddress = advert.AdvertAddress;
                        var distance = DistanceCalculator.CalculateDistance(userPromptAddress.Latitude, userPromptAddress.Longitude, advertAddress.Latitude, advertAddress.Longitude);
                        Console.WriteLine("Distance: " + distance);

                        if (distance < advertFilter.AcceptableDistance)
                        {
                            locationFilteredAdverts.Add(advert);
                        }
                        
                    }
                }
            }
            else
            {
                locationFilteredAdverts = queryFilteredAdverts;
            }

            return locationFilteredAdverts;
        }
    }
}
