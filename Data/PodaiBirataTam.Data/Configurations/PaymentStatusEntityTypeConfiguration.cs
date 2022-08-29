using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Configurations
{
    internal class PaymentStatusEntityTypeConfiguration : IEntityTypeConfiguration<PaymentStatus>
    {
        public void Configure(EntityTypeBuilder<PaymentStatus> paymentStatus)
        {
            paymentStatus.Property(x => x.Status)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
