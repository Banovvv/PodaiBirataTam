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

        public async Task<Beer?> GetByUsernameAsync(string name)
        {
            return await this.Context.Beers
                .FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}
