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
            var filterQuery = dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .AsQueryable();


            //FILTERING CONDITIONS
            {
                if (advertFilter.CompanyID != null)
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

                if (advertFilter.MinSalary != null)
                {
                    filterQuery = filterQuery.Where(x => x.MinSalary >= advertFilter.MinSalary);
                }

                if (advertFilter.MaxSalary != null)
                {
                    filterQuery = filterQuery.Where(x => x.MaxSalary <= advertFilter.MaxSalary);
                }

                if (advertFilter.CVMandatory != null)
                {
                    filterQuery = filterQuery.Where(x => x.CVMandatory == advertFilter.CVMandatory);
                }

            }

            var queryFilteredAdverts = await filterQuery
                .ToListAsync();

            var locationFilteredAdverts = new List<Advert>();


            if(advertFilter.Location != null)
            {
                var apiAdressDetails = await locationService.GetCoordinatesAsync(advertFilter.Location);

                if (apiAdressDetails != null)
                {
                    foreach (var advert in queryFilteredAdverts)
                    {
                        var advertAddress = await address.GetByAddressID(advert.AdvertAdressID);
                        var distance = DistanceCalculator.CalculateDistance(apiAdressDetails.Latitude, apiAdressDetails.Longitude, advertAddress.Latitude, advertAddress.Longitude);

                        if (distance <= advertFilter.AcceptableDistance)
                        {
                            locationFilteredAdverts.Add(advert);
                        }
                        //TODO: REPAIR deleting from list, zabezpieczenie i cachowanie (sciaganie z cachu)
                    }
                }
            }

            return locationFilteredAdverts;
        }
    }
}
