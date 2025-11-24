using ComandaPro.Domain.Base;

namespace ComandaPro.Domain.Entities
{
    public class Payment : BaseEntity<int>
    {
        public Payment()
        {

        }

        public Payment(int id, Order order, string paymentMethod, Decimal valuePaid, DateTime paymentDate) : base(id)
        {
            Order = order;
            PaymentMethod = paymentMethod;
            ValuePaid = valuePaid;
            PaymentDate = paymentDate;
        }

        public Order Order { get; set; }
        public string PaymentMethod { get; set; }
        public Decimal ValuePaid { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
