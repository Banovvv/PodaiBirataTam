using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class BeerEntityTypeConfiguration : IEntityTypeConfiguration<Beer>
    {
        public void Configure(EntityTypeBuilder<Beer> beer)
        {
            beer.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(true);

            beer.Property(x => x.Description)
                .IsRequired(false)
                .IsUnicode(true);

        }
    }
}
