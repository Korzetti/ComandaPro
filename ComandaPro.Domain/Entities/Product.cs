using ComandaPro.Domain.Base;

namespace ComandaPro.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {

        }

        public Product(int id, Category category, string name, Decimal price, string description) : base(id)
        {
            Category = category;
            Name = name;
            Price = price;
            Description = description;
        }

        public Category Category { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public string Description { get; set; }
    }
}
