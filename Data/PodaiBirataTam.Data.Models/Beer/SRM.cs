namespace PodaiBirataTam.Data.Models
{
    public class SRM
    {
        public SRM()
        {
            Beers = new HashSet<Beer>();
        }
        public int Id { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
