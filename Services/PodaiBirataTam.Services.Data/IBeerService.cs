using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Services.Data
{
    public interface IBeerService
    {
        int GetCount();
        IEnumerable<Beer> GetAll<Beer>();
    }
}
