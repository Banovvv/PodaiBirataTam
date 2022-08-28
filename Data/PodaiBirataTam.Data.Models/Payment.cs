namespace PodaiBirataTam.Data.Models
{
    public class Payment
    {
        public Payment()
        {
        }

        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidOn { get; set; }

        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

        public int StatusId { get; set; }
        public virtual PaymentStatus Status { get; set; }
    }
}
