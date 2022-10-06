using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Common.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetByEmailAsync(string email);
        Task<Customer?> GetByUsernameAsync(string username);
    }
}
