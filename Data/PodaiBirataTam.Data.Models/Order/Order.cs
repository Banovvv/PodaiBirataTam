﻿namespace PodaiBirataTam.Data.Models
{
    public class Order
    {
        public Order()
        {
            Invoices = new HashSet<Invoice>();
            Shipments = new HashSet<Shipment>();
            Items = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Details { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int StatusId { get; set; }
        public virtual OrderStatus Status { get; set; }

        public virtual ICollection<Invoice> Invoices { get; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }
    }
}