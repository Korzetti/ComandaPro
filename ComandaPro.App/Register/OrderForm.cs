using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;

namespace ComandaPro.App.Register
{
    public partial class OrderForm : Form
    {
        private IBaseService<Order> _orderService;
        private IBaseService<ItemOrder> _itemOrderService;
        private List<OrderViewModel> orders;
        private List<ItemOrderViewModel> itemOrders;

        public OrderForm(IBaseService<ItemOrder> itemOrderService, IBaseService<Order> orderService)
        {
            _itemOrderService = itemOrderService;
            _orderService = orderService;
            InitializeComponent();
            PopulateOrderGrid();
            ConfigureOrderGrid();
        }

        private void ConfigureOrderGrid()
        {
            gridOrders.ForeColor = Color.Black;
            gridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOrders.Columns["TotalValue"].DefaultCellStyle.Format = "c";
            gridOrders.Columns["TotalValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void PopulateOrderGrid()
        {
            orders = _orderService.Get<OrderViewModel>()
                    .ToList();
            gridOrders.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gridOrders.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this register?", "Comanda Pro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int orderId = (int)gridOrders.SelectedRows[0].Cells["Id"].Value;
                    itemOrders = _itemOrderService.Get<ItemOrderViewModel>()
                                                  .Where(io => io.OrderId == orderId)
                                                  .ToList();

                    foreach (var itemOrder in itemOrders)
                    {
                        _itemOrderService.Delete(itemOrder.Id);
                    }

                    _orderService.Delete(orderId);
                    PopulateOrderGrid();
                }
            }
            else
            {
                MessageBox.Show("Select a register to delete!", "ComandaPro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
