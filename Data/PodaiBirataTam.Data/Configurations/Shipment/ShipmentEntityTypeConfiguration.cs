using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class ShipmentEntityTypeConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> shipment)
        {
            shipment.Property(x => x.TrackingNumber)
                .IsRequired(true)
                .IsUnicode(false);

            shipment.Property(x => x.Details)
                .IsRequired(false)
                .IsUnicode(true);

            shipment.Property(x => x.ShippedOn)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired(true);

            shipment.Property(x => x.DeliveredOn)
                .IsRequired(false);                
        }
    }
}
