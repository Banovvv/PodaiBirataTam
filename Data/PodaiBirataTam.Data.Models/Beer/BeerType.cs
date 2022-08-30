namespace PodaiBirataTam.Data.Models
{
    public class BeerType
    {
        public BeerType()
        {
            BeerStyles = new HashSet<BeerStyle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BeerStyle> BeerStyles { get; set; }
    }
}
