namespace PodaiBirataTam.Data.Models
{
    public class BeerStyle
    {
        public BeerStyle()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? TypeId { get; set; }
        public virtual BeerType Type { get; set; }
    }
}
