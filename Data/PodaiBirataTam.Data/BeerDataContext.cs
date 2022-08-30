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

        // Address-related DbSets
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Country> Countries { get; set; }

        // Beer-related DbSets
        public virtual DbSet<Beer> Beers { get; set; }
        public virtual DbSet<Brewery> Breweries { get; set; }
        public virtual DbSet<BeerStyle> BeerStyles { get; set; }
        public virtual DbSet<BeerType> BeerTypes { get; set; }
        public virtual DbSet<SRM> SRMs { get; set; }

        // Customer-related DbSets
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        // Invoice-related DbSets
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceStatus> InvoiceStatuses { get; set; }

        // Order-related DbSets
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<OrderShipment> OrderShipments { get; set; }
        public virtual DbSet<OrderItemStatus> OrderItemStatuses { get; set; }

        // Payment-related DbSets
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

        // Shipment-related DbSets
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<ShipmentStatus> ShipmentStatuses { get; set; }

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
            new BeerEntityTypeConfiguration().Configure(modelBuilder.Entity<Beer>());
            new BreweryEntityTypeConfiguration().Configure(modelBuilder.Entity<Brewery>());
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
            new OrderItemEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderItem>());
            new OrderStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderStatus>());
            new OrderShipmentEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderShipment>());
            new OrderItemStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderItemStatus>());

            // Payment-related configurations
            new PaymentEntityTypeConfiguration().Configure(modelBuilder.Entity<Payment>());
            new PaymentStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<PaymentStatus>());

            // Shipment-related configurations
            new ShipmentEntityTypeConfiguration().Configure(modelBuilder.Entity<Shipment>());
            new ShipmentStatusEntityTypeConfiguration().Configure(modelBuilder.Entity<ShipmentStatus>());
        }
    }
}