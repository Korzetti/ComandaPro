using ComandaPro.App.Base;
using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using ComandaPro.Service.Validators;

namespace ComandaPro.App.Register
{
    public partial class ProductForm : BaseForm
    {
        private IBaseService<Product> _productService;
        private IBaseService<Category> _categoryService;
        private List<ProductViewModel>? products;

        private int _selectedProductId;
        public ProductForm(IBaseService<Product> productService, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var categories = _categoryService.Get<Category>().OrderBy(c => c.Name).ToList();
            categoryCbo.DataSource = categories;
            categoryCbo.DisplayMember = "Name";
            categoryCbo.ValueMember = "Id";

        }

        private void FormToObject(Product product)
        {
            product.Name = nameTxt.Text;
            product.Description = descriptionTxt.Text;
            product.Category = _categoryService.GetById<Category>((int)categoryCbo.SelectedValue);
            product.Price = decimal.Parse(priceTxt.Text);
        }

        protected override void Save()
        {
            try
            {
                Product product;

                if (IsEditMode)
                {
                    product = _productService.GetById<Product>(_selectedProductId);
                    FormToObject(product);
                    product = _productService.Update<Product, Product, ProductValidator>(product);
                }
                else
                {
                    product = new Product();
                    FormToObject(product);
                    product = _productService.Add<Product, Product, ProductValidator>(product);
                }
                tabControlRegister.SelectedTab = tabPageList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _categoryService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            products = _productService.Get<ProductViewModel>()
                .Where(p => p.CategoryUserId == MainForm.User.Id)
                .ToList();
            dataGridViewList.DataSource = products;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewList.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridViewList.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewList.Columns["CategoryName"].HeaderText = "Category";
            dataGridViewList.Columns["CategoryUserId"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            _selectedProductId = (int)record?.Cells["Id"].Value;
            nameTxt.Text = record?.Cells["Name"].Value.ToString();
            priceTxt.Text = record?.Cells["Price"].Value.ToString();
            descriptionTxt.Text = record?.Cells["Description"].Value.ToString();
            categoryCbo.SelectedValue = record?.Cells["CategoryId"].Value;
        }
    }
}
