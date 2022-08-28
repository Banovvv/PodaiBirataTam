namespace PodaiBirataTam.Data.Models
{
    public class Beer
    {
        public Beer()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Kcal { get; set; }
        public double Abv { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedOn { get; set; }

        public int BreweryId { get; set; }
        public virtual Brewery Brewery { get; set; }

        public int StyleId { get; set; }
        public virtual BeerStyle Style { get; set; }

        public int? SRMId { get; set; }
        public virtual SRM SRM { get; set; }

        public int? TownId { get; set; }
        public virtual Town Town { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
