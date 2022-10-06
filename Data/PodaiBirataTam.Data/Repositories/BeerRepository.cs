using Microsoft.EntityFrameworkCore;
using PodaiBirataTam.Data.Common.Repositories;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Repositories
{
    public class BeerRepository : Repository<Beer>, IBeerRepository
    {
        public BeerRepository(BeerDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Beer>> GetByStyleAsync(string style)
        {
            return await this.Context.Beers
                .Include(x => x.Style)
                .Where(x => x.Style.Name.ToLower() == style.ToLower())
                .ToListAsync();
        }

        public async Task<Beer?> GetByNameAsync(string name)
        {
            return await this.Context.Beers
                .FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<IEnumerable<Beer>> GetBelowPriceAsync(decimal price)
        {
            return await this.Context.Beers
                .Where(x => x.Price <= price)
                .ToListAsync();
        }

        public async Task<IEnumerable<Beer>> GetByBreweryAsync(string breweryName)
        {
            return await this.Context.Beers
                .Include(x => x.Brewery)
                .Where(x => x.Brewery.Name == breweryName)
                .ToListAsync();
        }

        public async Task<IEnumerable<Beer>> GetInStock()
        {
            return await this.Context.Beers
                .Where(x => x.Quantity > 0)
                .ToListAsync();
        }
    }
}
