using Application.Exceptions;
using Application.Services;
using Core.Entities.Shared;
using Core.Interfaces.Shared;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories.Shared
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AuroraDbContext dbContext;
        private readonly ILocationService locationService;

        public AddressRepository(AuroraDbContext dbContext, ILocationService locationService)
        {
            this.dbContext = dbContext;
            this.locationService = locationService;
        }

        public Task<Address> GetAddressByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveAddress(Address address)
        {
            string addressString = $"{address.StreetNumber} {address.Street} {address.City} {address.Country}";
            var apiAddress = await locationService.GetCoordinatesAsync(addressString);


            if (apiAddress != null)
            {
                address.Latitude = apiAddress.Latitude;
                address.Longitude = apiAddress.Longitude;
                address.Country = apiAddress.Country;
                address.Region = apiAddress.Region;
                address.City = apiAddress.City;
                address.Street = apiAddress.Street;
                address.StreetNumber = apiAddress.StreetNumber;
            }
            else
            {
                throw new GeocodingException("Provided address is incorrect. Please provide correct address.");
            }


            await dbContext.Address.AddAsync(address);
            await dbContext.SaveChangesAsync();

            return address.AddressID;
        }
    }
}
