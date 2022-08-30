using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class OrderShipmentEntityTypeConfiguration : IEntityTypeConfiguration<OrderShipment>
    {
        public void Configure(EntityTypeBuilder<OrderShipment> orderShipment)
        {
            orderShipment.HasKey(x => new { x.ShipmentId, x.OrderId });
        }
    }
}
