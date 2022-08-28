namespace PodaiBirataTam.Data.Models
{
    public class PaymentStatus
    {
        public PaymentStatus()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
