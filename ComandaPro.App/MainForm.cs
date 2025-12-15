using ComandaPro.App.Infra;
using ComandaPro.App.Others;
using ComandaPro.App.Others.CustomerForms;
using ComandaPro.App.Others.RestaurantForms;
using ComandaPro.App.Register;
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
            restaurantPanel.Visible = false;
            customerPanel.Visible = false;

            if (User.UserType == null) return;

            switch (User.UserType)
            {
                case User.Type.Admin:
                    adminPanel.Visible = true;
                    break;

                case User.Type.Restaurant:
                    restaurantPanel.Visible = true;
                    break;

                case User.Type.Customer:
                    customerPanel.Visible = true;
                    break;

                default:
                    MessageBox.Show("Unknown user type.");
                    break;
            }
        }

        private void Logout()
        {
            User = null;

            formPanel.Visible = false;
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

            switch (button.Name)
            {
                case "btnCategory":
                    OpenPanelForm<CategoryForm>(formPanel);
                    break;
                case "btnProduct":
                    OpenPanelForm<ProductForm>(formPanel);
                    break;
                case "btnViewOrders":
                    OpenPanelForm<RestaurantOrders>(formPanel);
                    break;
                case "btnUser":
                    OpenPanelForm<UserListForm>(formPanel);
                    break;
                case "btnOrder":
                    OpenPanelForm<OrderForm>(formPanel);
                    break;
                case "btnRestaurants":
                    OpenPanelForm<RestaurantMenu>(formPanel);
                    break;
                case "btnMyOrders":
                    OpenPanelForm<ClientOrder>(formPanel);
                    break;
            }
        }

        private void minimizePb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closePb_Click(object sender, EventArgs e)
        {
            this.Close();
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
                formPanel.Visible = true;
            }
        }

    }
}
