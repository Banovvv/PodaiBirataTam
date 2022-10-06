using PodaiBirataTam.Data.Models;
using PodaiBirataTam.Data.Repositories;

namespace PodaiBirataTam.Services.Data
{
    public class BeerService : IBeerService
    {
        private readonly BeerRepository repository;

        public BeerService(BeerRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Beer> GetAll()
        {
            return this.repository.All().ToList();
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
            return this.repository.AllAsNoTracking().Count();
        }
    }
}
