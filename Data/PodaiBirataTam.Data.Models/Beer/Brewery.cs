namespace PodaiBirataTam.Data.Models
{
    public class Brewery
    {
        public Brewery()
        {
            Beers = new HashSet<Beer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public DateTime Since { get; set; }

        public int? AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
