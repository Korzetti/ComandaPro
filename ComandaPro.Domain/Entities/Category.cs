using ComandaPro.Domain.Base;   

namespace ComandaPro.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {

        }
        
        public Category(int id, string name, User user) : base(id)
        {
            Name = name;
            User = user; 
        }

        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
