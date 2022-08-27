namespace PodaiBirataTam.Data.Configurations
{
    internal static class Configuration
    {
        internal static string GetConnectionString()
        {
            return @"Server=.\SQLEXPRESS;Database=HospitalDatabase;Integrated Security=true;";
        }
    }
}
