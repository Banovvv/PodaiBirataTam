namespace PodaiBirataTam.Data.Models
{
    public class Address
    {
        public Address()
        {
        }

        public int Id { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LineThree { get; set; }
        public string LineFour { get; set; }

        public int TownId { get; set; }
        public virtual Town Town { get; set; }
    }
}
