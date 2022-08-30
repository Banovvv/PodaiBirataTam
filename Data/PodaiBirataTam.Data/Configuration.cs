namespace PodaiBirataTam.Data
{
    internal static class Configuration
    {
        internal static string GetConnectionString()
        {
            return @"Server=.\SQLEXPRESS;Database=PodaiBirataTam;Integrated Security=true;";
        }
    }
}
