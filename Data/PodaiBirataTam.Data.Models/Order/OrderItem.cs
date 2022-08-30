namespace PodaiBirataTam.Data.Models
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int BeerId { get; set; }
        public virtual Beer Beer { get; set; }

        public int StatusId { get; set; }
        public virtual OrderItemStatus Status { get; set; }
    }
}
