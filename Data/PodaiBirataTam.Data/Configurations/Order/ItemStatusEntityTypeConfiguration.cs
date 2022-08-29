using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class ItemStatusEntityTypeConfiguration : IEntityTypeConfiguration<ItemStatus>
    {
        public void Configure(EntityTypeBuilder<ItemStatus> itemStatus)
        {
            itemStatus.Property(x => x.Status)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
