using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class OrderItemEntityTypeConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> orderItem)
        {
            orderItem.HasOne(oi => oi.Order)
                .WithMany(o => o.Items)
                .OnDelete(DeleteBehavior.Restrict);

            orderItem.Property(oi => oi.OrderId).IsRequired(true);
        }
    }
}
