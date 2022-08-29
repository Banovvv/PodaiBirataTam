using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PodaiBirataTam.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodaiBirataTam.Data.Configurations
{
    internal class InvoiceStatusEntityTypeConfiguration : IEntityTypeConfiguration<InvoiceStatus>
    {
        public void Configure(EntityTypeBuilder<InvoiceStatus> invoiceStatus)
        {
            invoiceStatus.Property(x => x.Status)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
