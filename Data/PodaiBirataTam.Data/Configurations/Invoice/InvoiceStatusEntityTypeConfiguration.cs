using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class InvoiceStatusEntityTypeConfiguration : IEntityTypeConfiguration<InvoiceStatus>
    {
        public void Configure(EntityTypeBuilder<InvoiceStatus> invoiceStatus)
        {
            invoiceStatus.Property(x => x.Status)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(true);
        }
    }
}
