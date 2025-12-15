using ComandaPro.App.Infra;
using ComandaPro.App.Register;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using ComandaPro.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;

namespace ComandaPro.App.Others
{
    public partial class Login : Form
    {

        #region draggable form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        #endregion

        private readonly IBaseService<User> _userService;
        public Login(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        #region Events

        //
        // enterBtn
        //

        private void enterBtn_Click(object sender, EventArgs e)
        {
            User user = GetUser(emailTxt.Text, passwordTxt.Text);

            if (user == null)
            {
                MessageBox.Show("User/Password invalid!", "ComandaPro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user = _userService.Update<User, User, UserValidator>(user);
                MainForm.User = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        //
        //cancelPb
        //
        private void cancelPb_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cancelPb_MouseEnter(object sender, EventArgs e)
        {
            cancelPb.Cursor = Cursors.Hand;
        }

        private void cancelPb_MouseLeave(object sender, EventArgs e)
        {
            cancelPb.Cursor = Cursors.Default;
        }

        //
        //crownLabel3
        //
        private void crownLabel3_MouseEnter(object sender, EventArgs e)
        {
            registerLbl.Cursor = Cursors.Hand;
        }

        private void crownLabel3_MouseLeave(object sender, EventArgs e)
        {
            registerLbl.Cursor = Cursors.Default;
        }

        //
        //registerLbl
        //
        private void registerLbl_Click(object sender, EventArgs e)
        {
            var registerForm = ConfigureDI.serviceProvider!.GetService<UserForm>();

            if (registerForm != null && !registerForm.IsDisposed)
            {
                this.Visible = false;
                registerForm.ShowDialog();
                this.Visible = true;
            }
        }

        #endregion

        #region Methods
        private User? GetUser(string email, string password)
        {
            VerifyRegistratedUserExistance();
            var user = _userService.Get<User>().Where(x => x.Email == email).FirstOrDefault();
            if (user == null)
                return null;
            return user.Password != password ? null : user;
        }
        private void VerifyRegistratedUserExistance()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User
                {
                    Name = "System Admin",
                    Password = "@Admin12",
                    UserType = User.Type.Admin,
                    Address = "Admin Address",
                    Document = "0000000000",
                    Telephone = "00000000000",
                    Email = "admin@gmail.com"
                };
                _userService.Add<User, User, UserValidator>(user);
            }
        }

        #endregion

    }
}
