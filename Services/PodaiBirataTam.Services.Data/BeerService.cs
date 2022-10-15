using PodaiBirataTam.Data.Common.Repositories;
using PodaiBirataTam.Data.Models;
using PodaiBirataTam.Services.Data.Contracts;

namespace PodaiBirataTam.Services.Data
{
    public class BeerService : IBeerService
    {
        private readonly IBeerRepository repository;

        public BeerService(IBeerRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Beer>> GetBelowPriceAsync(decimal price)
        {
            return await this.repository.GetBelowPriceAsync(price);
        }

        public async Task<IEnumerable<Beer>> GetByBreweryAsync(string breweryName)
        {
            return await this.repository.GetByBreweryAsync(breweryName);
        }

        public async Task<IEnumerable<Beer>> GetByStyleAsync(string style)
        {
            return await this.repository.GetByStyleAsync(style);
        }

        public int GetCount()
        {
            return this.repository.GetCount();
        }

        public async Task<IEnumerable<Beer>> GetInStockAsync()
        {
            return await this.repository.GetInStockAsync();
        }

        public async Task<IEnumerable<Beer>> GetAllAsync()
        {
            return await this.repository.GetAllAsync();
        }
    }
}
