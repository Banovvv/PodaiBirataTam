using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Services.Data.Contracts
{
    public interface IShipmentService
    {
        Task<Shipment?> GetByTrackingNumberAsync(string trackingNumber);
        Task<IEnumerable<Shipment>> GetByStatusAsync(string status);
    }
}
