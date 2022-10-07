using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Common.Repositories
{
    public interface IShipmentRepository
    {
        Task<Shipment?> GetByTrackingNumberAsync(string trackingNumber);
        Task<IEnumerable<Shipment>> GetByStatusAsync(string status);
    }
}
