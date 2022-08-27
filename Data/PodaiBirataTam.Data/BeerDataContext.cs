using Microsoft.EntityFrameworkCore;
using PodaiBirataTam.Data.Configurations;

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

        }
    }
}