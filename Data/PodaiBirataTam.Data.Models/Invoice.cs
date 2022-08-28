namespace PodaiBirataTam.Data.Models
{
    public class Invoice
    {
        public Invoice()
        {
            Payments = new HashSet<Payment>();
            Shipments = new HashSet<Shipment>();
        }

        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime DueTo { get; set; }
        public string? Details { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int StatusId { get; set; }
        public virtual InvoiceStatus Status { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
    }
}
