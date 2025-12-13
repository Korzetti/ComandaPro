using ComandaPro.App.Infra;
using ComandaPro.App.Others;
using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace ComandaPro.App
{
    public partial class MainForm : Form
    {
        public static User User { get; set; }
        public MainForm()
        {
            InitializeComponent();
            LoadLogin();
        }

        private void LoadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<Login>();

            if (login.ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                if (User.UserType == User.Type.Admin)
                {
                    adminPanel.Visible = true;
                }

                nameLbl.Text = User.Name;
                emailLbl.Text = User.Email;
            }

        }

        #region Base Panel 

        private void Logout()
        {
            User = null;

            adminPanel.Visible = false;
            //customerPanel.Visible = false;

            this.Hide();
            LoadLogin();
            this.Show();
        }

        private void logoutPanel_Click(object sender, EventArgs e)
        {
            Logout();
        }

        #endregion

        #region Admin Panel

        private void mngPanel_Click(object sender, EventArgs e)
        {
            var button = sender as ReaLTaiizor.Controls.Button;

            if(button.Name == "userMngPanel") 
            {
                userMngPanel.Visible = true;
            }
        }

        #region User Management Panel

        #endregion

        #endregion

    }
}
