namespace PodaiBirataTam.Data.Models
{
    public class Shipment
    {
        public Shipment()
        {
        }

        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime ShippedOn { get; set; }
        public DateTime? DeliveredOn { get; set; }
        public string Details { get; set; }

        public int StatusId { get; set; }
        public virtual ShipmentStatus Status { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
