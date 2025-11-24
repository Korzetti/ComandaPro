using ComandaPro.Domain.Base;

namespace ComandaPro.Domain.Entities
{
    public class Order : BaseEntity<int>
    {
        public Order()
        {

        }

        public Order(int id, Customer customer, DateTime date_Time, string status, Decimal totalValue) : base(id)
        {
            Customer = customer;
            Date_Time = date_Time;
            Status = status;
            TotalValue = totalValue;
        }

        public Customer Customer { get; set; }
        public DateTime Date_Time { get; set; }
        public string Status { get; set; }
        public Decimal TotalValue { get; set; }

    }
}
