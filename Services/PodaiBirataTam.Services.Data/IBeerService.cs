using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Services.Data
{
    public interface IBeerService
    {
        int GetCount();
        IEnumerable<Beer> GetAll();
        Task<IEnumerable<Beer>> GetByStyleAsync(string style);
        Task<IEnumerable<Beer>> GetBelowPriceAsync(decimal price);
        Task<IEnumerable<Beer>> GetByBreweryAsync(string breweryName);
        Task<IEnumerable<Beer>> GetInStock();
    }
}
