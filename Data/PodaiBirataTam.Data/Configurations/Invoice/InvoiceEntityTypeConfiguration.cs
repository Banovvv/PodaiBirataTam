using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class InvoiceEntityTypeConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> invoice)
        {
            invoice.Property(x => x.Details)
                .IsRequired(false)
                .IsUnicode(true);

            invoice.Property(x => x.IssuedOn)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired(true);

            invoice.Property(x => x.DueOn)
                .HasDefaultValueSql("DATEADD(DAY, 14, GETDATE())")
                .IsRequired(true);

            invoice.HasOne(i => i.Order)
                .WithMany(o => o.Invoices)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
