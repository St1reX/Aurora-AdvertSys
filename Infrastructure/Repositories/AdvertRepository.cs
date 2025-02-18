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
    internal class AdvertRepository : IAdvertRepository
    {
        private readonly AuroraDbContext dbContext;
        private readonly ILocationService locationService;

        public AdvertRepository(AuroraDbContext dbContext, ILocationService locationService)
        {
            this.dbContext = dbContext;
            this.locationService = locationService;
        }

        public async Task<Advert?> GetAdvertById(int id)
        {
            var advert = await dbContext.Advert.Include(x => x.Company)
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.JobSector)
                .Include(x => x.SeniorityLevel)
                .Include(x => x.ContractType)
                .Include(x => x.EmploymentType)
                .Include(x => x.WorkModel)
                .Include(x => x.WorkDays)
                .Include(x => x.AdvertAddress)
                .FirstOrDefaultAsync(x => x.AdvertID == id);

            return advert;
        }

        public async Task<ICollection<Advert>?> GetAllAdverts()
        {
            var adverts = await dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .ToListAsync();

            return adverts;
        }

        public async Task<ICollection<Advert>?> GetFilteredAdverts(AdvertFilter advertFilter)
        {


            var filterQuery = dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .Include(x => x.AdvertAddress)
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



                advertFilter.Amount ??= 10;

                advertFilter.Offset ??= 0;
            }
           
            var queryFilteredAdverts = await filterQuery
                .Skip(advertFilter.Offset.Value)
                .Take(advertFilter.Amount.Value)
                .ToListAsync();

            
            //LOCATION FILTERING

            if (advertFilter.Location != null)
            {
                advertFilter.AcceptableDistance ??= 5;
                var coordinates = await locationService.GetCoordinatesAsync(advertFilter.Location);

                if (coordinates != null)
                {
                    var locationFilterQuery = dbContext.Advert.
                        FromSqlRaw("SELECT *, dbo.GetDistanceInKm({0}, {1}, CAST(Address.Latitude AS FLOAT), CAST(Address.Longitude AS FLOAT)) AS DistanceInKm" +
                        " FROM Advert JOIN Address ON Advert.AdvertAddressID = Address.AddressID" +
                        " WHERE dbo.GetDistanceInKm({0}, {1}, CAST(Address.Latitude AS FLOAT), CAST(Address.Longitude AS FLOAT)) <= {2}",
                        Convert.ToDouble(coordinates.Latitude), Convert.ToDouble(coordinates.Longitude), advertFilter.AcceptableDistance);

                    var locationFilterdAdverts = await locationFilterQuery.ToListAsync();

                    queryFilteredAdverts = queryFilteredAdverts
                    .Where(ad => locationFilterdAdverts.Any(locAd => locAd.AdvertID == ad.AdvertID))
                    .ToList();
                }
            }

            return queryFilteredAdverts;
        }
    }
}
