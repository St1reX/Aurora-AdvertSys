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

        public AdvertRepository(AuroraDbContext dbContext, ILocationService locationService)
        {
            this.dbContext = dbContext;
            this.locationService = locationService;
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
            var query = dbContext.Advert.AsQueryable();

            if(advertFilter.CompanyID != null)
            {
                query = query.Where(x => x.CompanyID == advertFilter.CompanyID);
            }

            if (advertFilter.PositionID != null)
            {
                query = query.Where(x => x.PositionID == advertFilter.PositionID);
            }

            if (advertFilter.SeniorityLevelID != null)
            {
                query = query.Where(x => x.SeniorityLevelID == advertFilter.SeniorityLevelID);
            }

            if(advertFilter.MinSalary != null)
            {
                query = query.Where(x => x.MinSalary >= advertFilter.MinSalary);
            }

            if(advertFilter.MaxSalary != null)
            {
                query = query.Where(x => x.MaxSalary <= advertFilter.MaxSalary);
            }

            if (advertFilter.CVMandatory != null)
            {
               query = query.Where(x => x.CVMandatory == advertFilter.CVMandatory);
            }

            var adverts = await query
                .ToListAsync();


            if(advertFilter.Location != null)
            {
                var userPromptAddress = await locationService.GetCoordinatesAsync(advertFilter.Location);

                if (userPromptAddress != null)
                {
                    Console.WriteLine(userPromptAddress.Latitude + " " + userPromptAddress.Longitude);

                    foreach (var advert in adverts)
                    {
                        var advertAddress = advert.AdvertAdress;
                        var distance = DistanceCalculator.CalculateDistance(userPromptAddress.Latitude, userPromptAddress.Longitude, advertAddress.Latitude, advertAddress.Longitude);
                        Console.WriteLine("Dsitane: " + distance);

                        if (distance > 20)
                        {
                            adverts.Remove(advert);
                        }
                        
                    }
                }
            }

            return adverts;
        }
    }
}
