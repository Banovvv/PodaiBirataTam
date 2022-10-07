using PodaiBirataTam.Data.Models;
using PodaiBirataTam.Data.Repositories;
using PodaiBirataTam.Services.Data.Contracts;

namespace PodaiBirataTam.Services.Data
{
    public class ShipmentService : IShipmentService
    {
        private readonly ShipmentRepository repository;

        public ShipmentService(ShipmentRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Shipment?> GetByTrackingNumberAsync(string trackingNumber)
        {
            return await this.repository.GetByTrackingNumberAsync(trackingNumber);
        }

        public async Task<IEnumerable<Shipment>> GetByStatusAsync(string status)
        {
            return await this.repository.GetByStatusAsync(status);
        }

    }
}
