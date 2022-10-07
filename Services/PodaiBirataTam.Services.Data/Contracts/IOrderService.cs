using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Services.Data.Contracts
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetByStatusAsync(string status);
        Task<IEnumerable<Order>> GetByCustomerAsync(string username);
    }
}
