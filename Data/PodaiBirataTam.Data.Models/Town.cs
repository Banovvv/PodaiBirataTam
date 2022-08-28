namespace PodaiBirataTam.Data.Models
{
    public class Town
    {
        public Town()
        {
            Addresses = new HashSet<Address>();
            Beers = new HashSet<Beer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Beer> Beers { get; set; }
    }
}
