using ComandaPro.App.Infra;
using ComandaPro.App.Others;
using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

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
                ConfigurePanels();

                nameLbl.Text = User.Name;
                emailLbl.Text = User.Email;
            }

        }

        private void ConfigurePanels()
        {
            adminPanel.Visible = false;
            //restaurantPanel.Visible = false;
            //customerPanel.Visible = false;

            if (User.UserType == null) return;

            switch (User.UserType)
            {
                case User.Type.Admin:
                    adminPanel.Visible = true;
                    break;

                case User.Type.Restaurant:
                   // pnlRestaurant.Visible = true;
                    break;

                case User.Type.Customer:
                    //pnlCustomer.Visible = true;
                    break;

                default:
                    MessageBox.Show("Unknown user type.");
                    break;
            }
        }

        private void Logout()
        {
            User = null;

            this.Hide();
            LoadLogin();
            this.Show();
        }

        private void logoutPanel_Click(object sender, EventArgs e)
        {
            Logout();
        }


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
