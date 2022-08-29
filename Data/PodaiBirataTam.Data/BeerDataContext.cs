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
            // Address-related configurations
            new AddressEntityTypeConfiguration().Configure(modelBuilder.Entity<Address>());
            new CountryEntityTypeConfiguration().Configure(modelBuilder.Entity<Country>());
            new TownEntityTypeConfiguration().Configure(modelBuilder.Entity<Town>());

            // Beer-related configurations
            new BeerStyleEntityTypeConfiguration().Configure(modelBuilder.Entity<BeerStyle>());
            new BeerTypeEntityTypeConfiguration().Configure(modelBuilder.Entity<BeerType>());
            new SRMEntityTypeConfiguration().Configure(modelBuilder.Entity<SRM>());

            // Customer-related configurations
            new CustomerEntityTypeConfiguration().Configure(modelBuilder.Entity<Customer>());
            new RoleEntityTypeConfiguration().Configure(modelBuilder.Entity<Role>());

            // Invoice-related configurations
            new InvoiceEntityTypeConfiguration().Configure(modelBuilder.Entity<Invoice>());
            new InvoiceStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<InvoiceStatus>());

            // Order-related configurations
            new OrderEntityTypeConfiguration().Configure(modelBuilder.Entity<Order>());
            new OrderStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderStatus>());
            new ItemStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<ItemStatus>());

            // Payment-related configurations
            new PaymentEntityTypeConfiguration().Configure(modelBuilder.Entity<Payment>());
            new PaymentStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<PaymentStatus>());

            // Shipment-related configurations
            new ShipmentEntityTypeConfiguration().Configure(modelBuilder.Entity<Shipment>());
            new ShipmentStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<ShipmentStatus>());
        }
    }
}