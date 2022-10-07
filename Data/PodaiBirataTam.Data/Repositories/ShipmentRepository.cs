using Microsoft.EntityFrameworkCore;
using PodaiBirataTam.Data.Common.Repositories;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Repositories
{
    public class ShipmentRepository : Repository<Shipment>, IShipmentRepository
    {
        public ShipmentRepository(BeerDataContext context) : base(context)
        {
        }

        public async Task<Shipment?> GetByTrackingNumberAsync(string trackingNumber)
        {
            return await this.Context.Shipments
                .FirstOrDefaultAsync(x => x.TrackingNumber == trackingNumber);
        }

        public async Task<IEnumerable<Shipment>> GetByStatusAsync(string status)
        {
            return await this.Context.Shipments
                .Include(x => x.Status)
                .Where(x => x.Status.Status == status)
                .ToListAsync();
        }
    }
}
