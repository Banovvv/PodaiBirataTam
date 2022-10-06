using PodaiBirataTam.Data.Common.Repositories;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BeerDataContext context) : base(context)
        {

        }

        public Task<Customer?> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Customer?> GetByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}
