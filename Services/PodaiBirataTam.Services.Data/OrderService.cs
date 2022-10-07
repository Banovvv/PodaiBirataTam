using PodaiBirataTam.Data.Common.Repositories;
using PodaiBirataTam.Data.Models;
using PodaiBirataTam.Services.Data.Contracts;

namespace PodaiBirataTam.Services.Data
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repository;

        public OrderService(IOrderRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Order>> GetByCustomerAsync(string username)
        {
            return await this.repository.GetByCustomerAsync(username);
        }

        public async Task<IEnumerable<Order>> GetByStatusAsync(string status)
        {
            return await this.repository.GetByStatusAsync(status);
        }
    }
}
