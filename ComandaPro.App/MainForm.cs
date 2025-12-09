using ReaLTaiizor.Forms;
using ComandaPro.App.Others;
using ComandaPro.App.Infra;
using Microsoft.Extensions.DependencyInjection;

namespace ComandaPro.App
{
    public partial class MainForm : LostForm
    {
        public MainForm()
        {
            InitializeComponent();
            LoadLogin();
        }

        private void LoadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<Login>();
            
            if (login != null && !login.IsDisposed)
            {
                Environment.Exit(0);
            }
            
        }
    }
}
