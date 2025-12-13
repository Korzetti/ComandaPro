using ComandaPro.App.Infra;
using ComandaPro.App.Others;
using ComandaPro.App.Register;
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

        private void mngPanel_Click(object sender, EventArgs e)
        {
            var button = sender as ReaLTaiizor.Controls.Button;

            if (button.Name == "btnUser")
            {
                userMngPanel.Visible = true;
                OpenPanelForm<UserListForm>(userMngPanel);
            }
            else if (button.Name == "btnRestaurant")
            {
                // Exemplo: AbrirFormNoPanel<RestaurantForm>(userMngPanel);
            }
            else if (button.Name == "btnOrder")
            {
                // Exemplo: AbrirFormNoPanel<OrderForm>(userMngPanel);
            }
        }

        private void OpenPanelForm<TFormulario>(Control targetPanel) where TFormulario : Form
        {
            if (targetPanel.Controls.Count > 0)
                targetPanel.Controls[0].Dispose();

            var form = ConfigureDI.serviceProvider!.GetService<TFormulario>();

            if (form != null && !form.IsDisposed)
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                targetPanel.Controls.Clear();
                targetPanel.Controls.Add(form);

                form.Show();
            }
        }

    }
}
