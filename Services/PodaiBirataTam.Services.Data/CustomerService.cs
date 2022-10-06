using PodaiBirataTam.Data.Models;
using PodaiBirataTam.Data.Repositories;
using PodaiBirataTam.Services.Data.Contracts;

namespace PodaiBirataTam.Services.Data
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerRepository repository;

        public CustomerService(CustomerRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Customer?> GetByEmailAsync(string email)
        {
            return await this.repository.GetByEmailAsync(email);
        }

        public async Task<Customer?> GetByUsernameAsync(string username)
        {
            return await this.repository.GetByUsernameAsync(username);
        }
    }
}
