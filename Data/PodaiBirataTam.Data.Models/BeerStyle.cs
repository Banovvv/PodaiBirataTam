namespace PodaiBirataTam.Data.Models
{
    public class BeerStyle
    {
        public BeerStyle()
        {
            Beers = new HashSet<Beer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? TypeId { get; set; }
        public virtual BeerType Type { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
