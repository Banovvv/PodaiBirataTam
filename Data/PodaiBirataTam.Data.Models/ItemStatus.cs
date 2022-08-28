namespace PodaiBirataTam.Data.Models
{
    public class ItemStatus
    {
        public ItemStatus()
        {
            Items = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<OrderItem> Items { get; set; }
    }
}
