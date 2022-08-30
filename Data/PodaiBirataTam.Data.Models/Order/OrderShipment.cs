namespace PodaiBirataTam.Data.Models
{
    public class OrderShipment
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
