using Microsoft.EntityFrameworkCore;
using PodaiBirataTam.Data.Common.Repositories;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BeerDataContext context) : base(context)
        {

        }

        public async Task<Customer?> GetByEmailAsync(string email)
        {
            return await this.Context.Customers
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<Customer?> GetByUsernameAsync(string username)
        {
            return await this.Context.Customers
                .FirstOrDefaultAsync(x => x.Username == username);
        }
    }
}
