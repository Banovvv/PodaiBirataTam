namespace PodaiBirataTam.Data.Models
{
    public class InvoiceStatus
    {
        public InvoiceStatus()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Invoice> Invoices { get; }
    }
}
