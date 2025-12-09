namespace ComandaPro.App.ViewModel
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal ValuePaid { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
