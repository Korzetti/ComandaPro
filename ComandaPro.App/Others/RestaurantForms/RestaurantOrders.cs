using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using ComandaPro.Service.Validators;

namespace ComandaPro.App.Others.RestaurantForms
{
    public partial class RestaurantOrders : Form
    {
        private IBaseService<Order> _orderService;
        private IBaseService<ItemOrder> _itemOrderService;
        private List<ItemOrderViewModel> itemOrders;

        public RestaurantOrders(IBaseService<Order> orderService, IBaseService<ItemOrder> itemOrderService)
        {
            _orderService = orderService;
            _itemOrderService = itemOrderService;
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

        private void ConfigureDetailGrid()
        {
            gridDetails.ForeColor = Color.Black;
            gridDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDetails.Columns["Id"].Visible = false;
            gridDetails.Columns["OrderId"].Visible = false;
            gridDetails.Columns["ProductId"].Visible = false;
            gridDetails.Columns["UnitPrice"].DefaultCellStyle.Format = "c";
            gridDetails.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void PopulateOrderGrid()
        {
            var includes = new List<string> { "Product", "Product.Category", "Order", "Order.User" };

            var restaurantId = MainForm.User.Id;
            var allItems = _itemOrderService.Get<ItemOrder>(includes)
                           .Where(io => io.Product.Category.UserId == restaurantId)
                           .Select(io => new RestaurantOrderViewModel
                           {
                               Id = io.Order.Id,
                               CustomerName = io.Order.User.Name,
                               OrderDate = io.Order.Date_Time,
                               Status = io.Order.Status,
                               TotalValue = io.Order.TotalValue
                           })
                           .DistinctBy(io => io.Id)
                           .OrderBy(io => io.Id)
                           .ToList();

            gridOrders.DataSource = allItems;
            gridOrders.Refresh();
        }

        private void PopulateDetailsGrid()
        {
            var includes = new List<string> { "Product" };

            tabControlList.SelectedTab = tabPageViewDetails;
            var selectedItemOrders = _itemOrderService.Get<ItemOrder>(includes)
                        .Where(io => io.OrderId == (int)gridOrders.SelectedRows[0].Cells["Id"].Value)
                        .Select(io => new ItemOrderViewModel
                        {
                            ProductName = io.Product.Name,
                            CategoryName = io.Product.Category.Name,
                            Quantity = io.Quantity,
                            UnitPrice = io.UnitPrice,
                        })
                        .ToList();

            gridDetails.DataSource = selectedItemOrders;
            ConfigureDetailGrid();
            gridDetails.Refresh();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            if (gridOrders.SelectedRows.Count > 0)
            {
                Order order = _orderService.GetById<Order>((int)gridOrders.SelectedRows[0].Cells["Id"].Value);
                int selectedIndex = gridOrders.SelectedRows[0].Index;

                switch (order.Status)
                {
                    case "Pending":
                        order.Status = "Preparing";
                        break;
                    case "Preparing":
                        order.Status = "Ready";
                        break;
                    case "Ready":
                        order.Status = "Delivered";
                        break;
                    case "Delivered":
                        MessageBox.Show("The order has already been delivered.", "ComandaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                _orderService.Update<Order, Order, OrderValidator>(order);
                PopulateOrderGrid();
                gridOrders.ClearSelection();
                gridOrders.Rows[selectedIndex].Selected = true;          
            }
            else
            {
                MessageBox.Show("Please select an order to advance status.", "ComandaPro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {      
            if (gridOrders.SelectedRows.Count > 0)
            {    
                PopulateDetailsGrid();
            }
            else
            {
                MessageBox.Show("Please select an order to view details.", "ComandaPro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tabControlList.SelectedTab = tabPageViewOrders;
        }
    }
}
