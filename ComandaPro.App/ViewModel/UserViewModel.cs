using ComandaPro.Domain.Entities;

namespace ComandaPro.App.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Document { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public User.Type UserType { get; set; }

    }
}
