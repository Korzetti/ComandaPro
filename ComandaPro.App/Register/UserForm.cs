using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using ComandaPro.Service.Validators;
using System.Runtime.InteropServices;

namespace ComandaPro.App.Register
{
    public partial class UserForm : Form
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

        private IBaseService<User> _userService;
        private List<UserViewModel> _users;
        private bool isRestaurant;

        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
            lostPanel2.Visible = false;
        }

        #region Methods

        private void onTypeClick()
        {
            lostPanel1.Visible = false;
            lostPanel2.Visible = true;
        }

        private void FormToObject(User user)
        {
            user.Name = nameTxt.Text;
            user.Telephone = phoneTxt.Text;
            user.Address = addressTxt.Text;
            user.Document = documentTxt.Text;
            user.Email = emailTxt.Text;
            user.Password = passwordTxt.Text;

            if (isRestaurant)
            {
                user.UserType = User.Type.Restaurant;
            }
            else
            {
                user.UserType = User.Type.Customer;

            }

        }

        protected virtual void Save()
        {
            try
            {
                var user = new User();
                FormToObject(user);
                user = _userService.Add<User, User, UserValidator>(user);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ComandaPro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            Save();
            
        }

        #endregion

        #region Events

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            crownLabel1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            button1.InactiveColor = Color.FromArgb(64, 64, 64);
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            crownLabel1.BackColor = Color.FromArgb(234, 88, 12);
            pictureBox1.BackColor = Color.FromArgb(234, 88, 12);
            button1.InactiveColor = Color.FromArgb(234, 88, 12);
            this.Cursor = Cursors.Default;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            crownLabel3.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox2.BackColor = Color.FromArgb(64, 64, 64);
            button2.InactiveColor = Color.FromArgb(64, 64, 64);
            this.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            crownLabel3.BackColor = Color.FromArgb(234, 88, 12);
            pictureBox2.BackColor = Color.FromArgb(234, 88, 12);
            button2.InactiveColor = Color.FromArgb(234, 88, 12);
            this.Cursor = Cursors.Default;
        }

        private void typeUser_Click(object sender, EventArgs e)
        {
            isRestaurant = false;
            documentLbl.Text = "CPF";
            onTypeClick();
        }

        private void typeRestaurant_Click(object sender, EventArgs e)
        {
            isRestaurant = true;
            documentLbl.Text = "CNPJ";
            onTypeClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lostPanel2.Visible = false;
            lostPanel1.Visible = true;
        }

        #endregion

    }
}
