using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class BeerTypeEntityTypeConfiguration : IEntityTypeConfiguration<BeerType>
    {
        public void Configure(EntityTypeBuilder<BeerType> beerType)
        {
            beerType.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(true);

            beerType.Property(x => x.Description)
                .IsRequired(false)
                .IsUnicode(true);
        }
    }
}
