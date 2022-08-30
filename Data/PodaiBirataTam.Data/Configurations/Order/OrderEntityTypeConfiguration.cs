using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> order)
        {
            order.Property(x => x.CreatedOn)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired(true);

            order.Property(x => x.Details)
                .IsRequired(false)
                .IsUnicode(true);

            order.HasMany(x => x.Items)
                .WithOne(x => x.Order)
                .OnDelete(DeleteBehavior.Restrict);

            order.HasMany(x => x.Invoices)
                .WithOne(x => x.Order)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
