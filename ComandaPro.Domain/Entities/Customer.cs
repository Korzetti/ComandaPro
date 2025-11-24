using ComandaPro.Domain.Base;

namespace ComandaPro.Domain.Entities
{
    public class Customer : BaseEntity<int>
    {
        public Customer()
        {

        }

        public Customer(int id, string name, string telephone, string address) : base(id)
        {
            Name = name;
            Telephone = telephone;
            Address = address;
        }

        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; } 
    }
}
