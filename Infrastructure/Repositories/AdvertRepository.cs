using Application.Services;
using Core.Entities;
using Core.Helpers;
using Core.Interfaces;
using Core.Utilities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class AdvertRepository : IAdvert
    {
        private readonly AuroraDbContext dbContext;
        private readonly ILocationService locationService;
        private readonly IAddress address;

        public AdvertRepository(AuroraDbContext dbContext, ILocationService locationService, IAddress address)
        {
            this.dbContext = dbContext;
            this.locationService = locationService;
            this.address = address;
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
            var query = dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .AsQueryable();

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
                var apiAdressDetails = await locationService.GetCoordinatesAsync(advertFilter.Location);

                if (apiAdressDetails != null)
                {
                    Console.WriteLine(apiAdressDetails.Latitude + " " + apiAdressDetails.Longitude);

                    foreach (var advert in adverts)
                    {
                        var advertAddress = await address.GetByAddressID(advert.AdvertAdressID);
                        var distance = DistanceCalculator.CalculateDistance(apiAdressDetails.Latitude, apiAdressDetails.Longitude, advertAddress.Latitude, advertAddress.Longitude);
                        Console.WriteLine("Distance: " + distance);

                        if (distance > advertFilter.AcceptableDistance)
                        {
                            adverts.Remove(advert);
                        }
                        //TODO: REPAIR deleting from list, zabezpieczenie i cachowanie (sciaganie z cachu)
                    }
                }
            }

            return adverts;
        }
    }
}
