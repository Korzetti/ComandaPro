using ComandaPro.App.Infra;
using ComandaPro.App.Register;
using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using ComandaPro.Service.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace ComandaPro.App.Others.CustomerForms
{
    public partial class RestaurantMenu : Form
    {
        private List<ItemOrder> _cart = new List<ItemOrder>();

        private IBaseService<Category> _categoryService;
        private IBaseService<User> _userService;
        private IBaseService<Product> _productService;
        private IBaseService<Order> _orderService;
        private IBaseService<ItemOrder> _itemOrderService;
        private List<UserViewModel> users;

        private int selectedId;

        public RestaurantMenu(IBaseService<User> userService,
                              IBaseService<Product> productService,
                              IBaseService<Category> categoryService,
                              IBaseService<Order> orderService,
                              IBaseService<ItemOrder> itemOrderService)
        {
            _userService = userService;
            _productService = productService;
            _categoryService = categoryService;
            _orderService = orderService;
            _itemOrderService = itemOrderService;
            InitializeComponent();
            PopulateGrids();
        }

        private void LoadData(int restaurantId)
        {
            var CategoryIdRestaurants = _categoryService.Get<Category>()
                                        .Where(c => c.UserId == restaurantId)
                                        .Select(c => c.Id)
                                        .ToList();

            var allProducts = _productService.Get<ProductViewModel>();

            var restaurantProducts = allProducts
                                        .Where(p => CategoryIdRestaurants.Contains(p.CategoryId))
                                        .ToList();

            dataGridProducts.DataSource = restaurantProducts;

            dataGridProducts.Columns["CategoryId"].Visible = false;
            dataGridProducts.Columns["CategoryName"].Visible = false;
            dataGridProducts.Columns["CategoryUserId"].Visible = false;
            dataGridProducts.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridProducts.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void PopulateGrids()
        {
            dataGridViewList.ForeColor = Color.Black;
            dataGridProducts.ForeColor = Color.Black;

            users = _userService.Get<UserViewModel>()
                .Where(u => u.UserType == User.Type.Restaurant)
                .ToList();

            dataGridViewList.DataSource = users;

            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewList.Columns["Id"].Visible = false;
            dataGridViewList.Columns["UserType"].Visible = false;
            dataGridViewList.Columns["Document"].Visible = false;
            dataGridViewList.Columns["Password"].Visible = false;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                selectedId = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;
                LoadData(selectedId);
                tabControlMenu.SelectedTab = tabPageRestaurantMenu;

            }
            else
            {
                MessageBox.Show("Select a restaurant!", "Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabPageRestaurantSel;
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridProducts.SelectedRows[0];
                var viewProduct = (ProductViewModel)selectedRow.DataBoundItem;

                var formQnt = ConfigureDI.serviceProvider.GetService<Quantity>();
                var originalProduct = _productService.GetById<Product>(viewProduct.Id);

                if (formQnt.ShowDialog() == DialogResult.OK)
                {
                    var newItem = new ItemOrder
                    {
                        ProductId = viewProduct.Id,
                        Product = originalProduct,
                        Quantity = formQnt.returnQnt,
                        UnitPrice = viewProduct.Price,
                        Observations = ""
                    };

                    _cart.Add(newItem);
                    UpdateCartGrid();
                    MessageBox.Show("Product added to cart!", "Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a Product!", "Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateCartGrid()
        {
            try
            {
                var dataToShow = _cart.Select(item => new
                {
                    Product = item.Product.Name,
                    Qnt = item.Quantity,
                    Price = item.UnitPrice,
                    Total = item.Quantity * item.UnitPrice
                }).ToList();

                dataGridCart.DataSource = null;
                dataGridCart.DataSource = dataToShow;
                dataGridCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridCart.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating cart " + ex.Message);
            }
        }

        private void finishOrderBtn_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newOrder = new Order
                {
                    User = MainForm.User,
                    Date_Time = DateTime.Now,
                    Status = "Pending",
                    TotalValue = _cart.Sum(i => i.UnitPrice * i.Quantity)
                };

                var savedOrder = _orderService.Add<Order, Order, OrderValidator>(newOrder);
                
                var formPayment = ConfigureDI.serviceProvider.GetService<PaymentForm>();
                formPayment.savedOrder = savedOrder;
                
                if(formPayment.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in _cart)
                    {
                        item.OrderId = savedOrder.Id;
                        item.Order = null;
                        item.Product = null;
                        _itemOrderService.Add<ItemOrder, ItemOrder, ItemOrderValidator>(item);
                    }
                    MessageBox.Show("Order placed successfully!", "Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearCart();
                }
                else
                {
                    if (savedOrder != null && savedOrder.Id > 0)
                    {
                        _orderService.Delete(savedOrder.Id);
                    }
                }          
            }
            catch (Exception ex)
            {

                if (savedOrder != null && savedOrder.Id > 0)
                {
                    _orderService.Delete(savedOrder.Id);
                }

                MessageBox.Show($"Error: {ex.Message}", "Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCart()
        {
            _cart.Clear();
            UpdateCartGrid();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
        }
    }
}
