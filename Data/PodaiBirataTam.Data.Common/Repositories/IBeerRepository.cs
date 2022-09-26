using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Common.Repositories
{
    public interface IBeerRepository
    {
        Task<Beer?> GetByUsernameAsync(string username);
    }
}
