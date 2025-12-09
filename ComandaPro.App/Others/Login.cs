using ComandaPro.App.Infra;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
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
            crownLabel3.Cursor = Cursors.Hand;
        }

        private void crownLabel3_MouseLeave(object sender, EventArgs e)
        {
            crownLabel3.Cursor = Cursors.Default;
        }

        private void crownLabel3_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
