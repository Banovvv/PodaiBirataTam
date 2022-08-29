using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class SRMEntityTypeConfiguration : IEntityTypeConfiguration<SRM>
    {
        public void Configure(EntityTypeBuilder<SRM> srm)
        {
            srm.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(false);
        }
    }
}
