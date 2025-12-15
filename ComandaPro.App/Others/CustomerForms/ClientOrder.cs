using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;

namespace ComandaPro.App.Others.CustomerForms
{
    public partial class ClientOrder : Form
    {
        private IBaseService<Order> _orderService;
        private List<OrderViewModel>? orders;

        public ClientOrder(IBaseService<Order> orderService)
        {
            _orderService = orderService;
            InitializeComponent();
            PopulateGrid();
        }
        
        private void PopulateGrid()
        {
            orders = _orderService.Get<OrderViewModel>()
                .Where(o => o.UserId == MainForm.User.Id)
                .ToList();

            dataGridOrders.DataSource = orders;
            dataGridOrders.ForeColor = Color.Black;
            dataGridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOrders.Columns["UserId"].Visible = false;
            dataGridOrders.Columns["TotalValue"].DefaultCellStyle.Format = "c";
            dataGridOrders.Columns["TotalValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridOrders.Columns["TotalValue"].HeaderText = "Total";
        }
    }
}
