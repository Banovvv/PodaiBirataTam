using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Services.Data.Contracts
{
    public interface ICustomerService
    {
        Task<Customer?> GetByEmailAsync(string email);
        Task<Customer?> GetByUsernameAsync(string username);
    }
}
