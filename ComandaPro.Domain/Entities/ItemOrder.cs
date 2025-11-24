using ComandaPro.Domain.Base;

namespace ComandaPro.Domain.Entities
{
    public class ItemOrder : BaseEntity<int>
    {
        public ItemOrder()
        {

        }

        public ItemOrder(int id, Order order, Product product, int quantity, Decimal unitPrice, string observations) : base(id)
        {
            Order = order;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Observations = observations;
        }

        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
        public string Observations { get; set; }

    }
}
