namespace PodaiBirataTam.Data.Models
{
    public class Shipment
    {
        public Shipment()
        {
            Orders = new HashSet<OrderShipment>();
        }

        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime ShippedOn { get; set; }
        public DateTime? DeliveredOn { get; set; }
        public string Details { get; set; }

        public int StatusId { get; set; }
        public virtual ShipmentStatus Status { get; set; }

        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

        public virtual ICollection<OrderShipment> Orders { get; set; }
    }
}
