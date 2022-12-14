namespace PodaiBirataTam.Data.Models
{
    public class Role
    {
        public Role()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
