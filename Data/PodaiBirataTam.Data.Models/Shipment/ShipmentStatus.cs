namespace PodaiBirataTam.Data.Models
{
    public class ShipmentStatus
    {
        public ShipmentStatus()
        {
            Shipments = new HashSet<Shipment>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Shipment> Shipments { get; set; }
    }
}
