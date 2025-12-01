using ComandaPro.Domain.Base;

namespace ComandaPro.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User()
        {

        }

        public User(int id, string name, string telephone, string address, string document, string password, string email, bool isRestaurant) : base(id)
        {
            Name = name;
            Telephone = telephone;
            Address = address;
            Document = document;
            Password = password;
            Email = email;
            IsRestaurant = isRestaurant;
        }

        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; } 
        public string Document { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Boolean IsRestaurant { get; set; }
    }
}
