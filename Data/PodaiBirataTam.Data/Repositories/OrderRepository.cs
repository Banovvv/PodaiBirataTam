using Microsoft.EntityFrameworkCore;
using PodaiBirataTam.Data.Common.Repositories;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(BeerDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> GetByStatusAsync(string status)
        {
            return await this.DbSet
                .Include(x => x.Status)
                .Where(x => x.Status.Status == status)
                .ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetByCustomerAsync(string username)
        {
            return await this.DbSet
                .Include(x => x.Customer)
                .Where(x => x.Customer.Username == username)
                .ToListAsync();
        }
    }
}
