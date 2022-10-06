using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Common.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetByStatusAsync(string status);
        Task<IEnumerable<Order>> GetByUserAsync(string username);
    }
}
