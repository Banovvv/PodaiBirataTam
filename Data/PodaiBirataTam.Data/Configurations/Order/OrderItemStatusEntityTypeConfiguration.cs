using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class OrderItemStatusEntityTypeConfiguration : IEntityTypeConfiguration<OrderItemStatus>
    {
        public void Configure(EntityTypeBuilder<OrderItemStatus> itemStatus)
        {
            itemStatus.Property(x => x.Status)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(true);
        }
    }
}
