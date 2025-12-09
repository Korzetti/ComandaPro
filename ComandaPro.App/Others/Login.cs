using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;

namespace ComandaPro.App.Others
{
    public partial class Login : Form
    {
        private readonly IBaseService<User> _userService;
        public Login(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
