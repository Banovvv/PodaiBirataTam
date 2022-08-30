using Microsoft.EntityFrameworkCore;
using PodaiBirataTam.Data;

var context = new BeerDataContext();
context.Database.Migrate();