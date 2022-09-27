namespace PodaiBirataTam.Services.Data
{
    public interface IBeerService
    {
        int GetCount();
        IEnumerable<T> GetAll<T>();
    }
}
