using Application.Services;
using Core.Entities;
using Core.Entities.AdvertDependent;
using Core.Helpers;
using Core.Interfaces.AdvertDependent;
using Core.Utilities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.AdvertDependent
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

        public async Task AddAdvertExposure(int id)
        {
            var advertExposures = 
                await dbContext.AdvertExposures.
                FirstOrDefaultAsync(x => DateTime.Compare(x.ExposureDate, DateTime.Now.Date) == 0 && x.AdvertID == id);

            if (advertExposures == null)
            {
                dbContext.AdvertExposures.Add(new AdvertExposures
                {
                    ExposureAmount = 1,
                    ExposureDate = DateTime.Now.Date,
                    AdvertID = id
                });
            }
            else
            {
                advertExposures.ExposureAmount++;
            }

            await dbContext.SaveChangesAsync();
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
            double? latitude = null, longitude = null;

            if (!string.IsNullOrEmpty(advertFilter.Location))
            {
                var coordinates = await locationService.GetCoordinatesAsync(advertFilter.Location);
                if (coordinates != null)
                {
                    latitude = Convert.ToDouble(coordinates.Latitude);
                    longitude = Convert.ToDouble(coordinates.Longitude);
                }
            }

            var filteredAdvertsID = await dbContext.Advert
                .FromSqlRaw("EXEC FilterAdverts @CompanyID={0}, @PositionID={1}, @SeniorityLevelID={2}, " +
                            "@MinSalary={3}, @MaxSalary={4}, @CvMandatory={5}, " +
                            "@Latitude={6}, @Longitude={7}, @MaxDistance={8}," +
                            "@Amount={9}, @Offset={10}",
                    advertFilter.CompanyID ?? (object)DBNull.Value,
                    advertFilter.PositionID ?? (object)DBNull.Value,
                    advertFilter.SeniorityLevelID ?? (object)DBNull.Value,
                    advertFilter.MinSalary ?? (object)DBNull.Value,
                    advertFilter.MaxSalary ?? (object)DBNull.Value,
                    advertFilter.CVMandatory ?? (object)DBNull.Value,
                    latitude ?? (object)DBNull.Value,
                    longitude ?? (object)DBNull.Value,
                    advertFilter.AcceptableDistance ?? (object)DBNull.Value,
                    advertFilter.Amount ?? (object)DBNull.Value,
                    advertFilter.Offset ?? (object)DBNull.Value)
                .ToListAsync();

            var filteredAdverts = await dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .Where(x => filteredAdvertsID.Select(y => y.AdvertID).Contains(x.AdvertID))
                .ToListAsync();
                
            return filteredAdverts;
        }
    }
}
