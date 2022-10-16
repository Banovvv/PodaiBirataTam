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
            return await this.DbSet
                .Include(x => x.Style)
                .Where(x => x.Style.Name.ToLower() == style.ToLower())
                .ToListAsync();
        }

        public async Task<Beer?> GetByNameAsync(string name)
        {
            return await this.DbSet
                .FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<IEnumerable<Beer>> GetBelowPriceAsync(decimal price)
        {
            return await this.DbSet
                .Where(x => x.Price <= price)
                .ToListAsync();
        }

        public async Task<IEnumerable<Beer>> GetByBreweryAsync(string breweryName)
        {
            return await this.DbSet
                .Include(x => x.Brewery)
                .Where(x => x.Brewery.Name == breweryName)
                .ToListAsync();
        }

        public async Task<IEnumerable<Beer>> GetInStockAsync()
        {
            return await this.DbSet
                .Where(x => x.Quantity > 0)
                .ToListAsync();
        }

        public int GetCount()
        {
            return this.AllAsNoTracking().Count();
        }

        public async Task<IEnumerable<Beer>> GetAllAsync()
        {
            return await this.DbSet
                .ToListAsync();
        }
    }
}
