namespace PodaiBirataTam.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Details { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int StatusId { get; set; }
        public virtual OrderStatus Status { get; set; }
    }
}
