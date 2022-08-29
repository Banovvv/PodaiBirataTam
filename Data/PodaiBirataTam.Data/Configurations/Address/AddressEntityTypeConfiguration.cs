using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class AddressEntityTypeConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> address)
        {
            address.Property(x => x.LineOne)
                .IsRequired(true)
                .HasMaxLength(150)
                .IsUnicode(true);

            address.Property(x => x.LineTwo)
                .IsRequired(false)
                .HasMaxLength(150)
                .IsUnicode(true);

            address.Property(x => x.LineThree)
                .IsRequired(false)
                .HasMaxLength(150)
                .IsUnicode(true);

            address.Property(x => x.LineFour)
                .IsRequired(false)
                .HasMaxLength(150)
                .IsUnicode(true);
        }
    }
}
