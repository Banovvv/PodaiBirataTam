using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class BreweryEntityTypeConfiguration : IEntityTypeConfiguration<Brewery>
    {
        public void Configure(EntityTypeBuilder<Brewery> brewery)
        {
            brewery.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(true);

            brewery.Property(x => x.PhoneNumber)
                .IsRequired(false)
                .HasMaxLength(20)
                .IsUnicode(false);

            brewery.Property(x => x.Website)
                .IsRequired(false)
                .HasMaxLength(40)
                .IsUnicode(true);

            brewery.Property(x => x.Since)
                .IsRequired(false);
        }
    }
}
