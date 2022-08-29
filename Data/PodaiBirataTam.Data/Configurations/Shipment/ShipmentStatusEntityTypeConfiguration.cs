using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class ShipmentStatusEntityTypeConfiguration : IEntityTypeConfiguration<ShipmentStatus>
    {
        public void Configure(EntityTypeBuilder<ShipmentStatus> shipmentStatus)
        {
            shipmentStatus.Property(x => x.Status)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(true);
        }
    }
}
