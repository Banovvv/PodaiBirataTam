﻿using PodaiBirataTam.Data.Models;

namespace PodaiBirataTam.Data.Common.Repositories
{
    public interface IBeerRepository
    {
        Task<Beer?> GetByNameAsync(string name);
        Task<IEnumerable<Beer>> GetByStyleAsync(string style);
        Task<IEnumerable<Beer>> GetBelowPriceAsync(decimal price);
        Task<IEnumerable<Beer>> GetByBreweryAsync(string breweryName);
        Task<IEnumerable<Beer>> GetInStock();
    }
}
