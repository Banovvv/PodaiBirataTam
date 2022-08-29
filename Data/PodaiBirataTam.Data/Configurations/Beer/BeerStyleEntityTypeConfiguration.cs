using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class BeerStyleEntityTypeConfiguration : IEntityTypeConfiguration<BeerStyle>
    {
        public void Configure(EntityTypeBuilder<BeerStyle> beerStyle)
        {
            beerStyle.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(true);

            beerStyle.Property(x => x.Description)
                .IsRequired(false)
                .IsUnicode(true);
        }
    }
}
