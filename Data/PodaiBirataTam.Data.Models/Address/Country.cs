namespace PodaiBirataTam.Data.Models
{
    public class Country
    {
        public Country()
        {
            Towns = new HashSet<Town>();
            Beers = new HashSet<Beer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
        public virtual ICollection<Beer> Beers { get; set; }
    }
}