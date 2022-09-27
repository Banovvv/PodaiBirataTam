using PodaiBirataTam.Data.Repositories;

namespace PodaiBirataTam.Services.Data
{
    public class BeerService : IBeerService
    {
        private readonly BeerRepository repository;

        public BeerService(BeerRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Beer> GetAll<Beer>()
        {
            return (IEnumerable<Beer>)this.repository.All().ToList();
        }

        public int GetCount()
        {
            return this.repository.AllAsNoTracking().Count();
        }
    }
}
