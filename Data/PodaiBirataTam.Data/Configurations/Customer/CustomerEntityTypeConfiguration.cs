using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> customer)
        {
            customer
                .HasIndex(x => x.Username)
                .IsUnique();

            customer.Property(x => x.FirstName)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(true);

            customer.Property(x => x.MiddleName)
                .IsRequired(false)
                .HasMaxLength(50)
                .IsUnicode(true);

            customer.Property(x => x.LastName)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(true);

            customer.Property(x => x.Email)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            customer.Property(x => x.Username)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(true);

            customer.Property(x => x.Password)
                .IsRequired(true)
                .HasMaxLength(60)
                .IsUnicode(false);

            customer.Property(x => x.PhoneNumber)
                .IsRequired(true)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
