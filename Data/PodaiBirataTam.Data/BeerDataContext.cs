using Microsoft.EntityFrameworkCore;
using PodaiBirataTam.Data.Configurations;
using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data
{
    public class BeerDataContext : DbContext
    {
        public BeerDataContext()
        {
        }

        public BeerDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AddressEntityTypeConfiguration().Configure(modelBuilder.Entity<Address>());
            new CountryEntityTypeConfiguration().Configure(modelBuilder.Entity<Country>());
            new TownEntityTypeConfiguration().Configure(modelBuilder.Entity<Town>());
            new InvoiceEntityTypeConfiguration().Configure(modelBuilder.Entity<Invoice>());
            new InvoiceStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<InvoiceStatus>());
            new OrderEntityTypeConfiguration().Configure(modelBuilder.Entity<Order>());
            new OrderStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderStatus>());
            new ItemStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<ItemStatus>());
            new PaymentEntityTypeConfiguration().Configure(modelBuilder.Entity<Payment>());
            new PaymentStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<PaymentStatus>());
        }
    }
}