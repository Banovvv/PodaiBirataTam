using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Services.Data
{
    public interface ICustomerService
    {
        Task<Customer?> GetByEmailAsync(string email);
        Task<Customer?> GetByUsernameAsync(string username);
    }
}
