using ComandaPro.App.Base;
using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using ComandaPro.Service.Validators;

namespace ComandaPro.App.Register
{
    public partial class CategoryForm : BaseForm
    {
        private IBaseService<Category> _categoryService;
        private List<CategoryViewModel>? categories;

        private int _selectedCategoryId;
        public CategoryForm(IBaseService<Category> categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }

        private void FormToObject(Category category)
        {
            category.Name = nameTxt.Text;
        }

        protected override void Save()
        {
            try
            {
                Category category;

                if (IsEditMode)
                {
                    category = _categoryService.GetById<Category>(_selectedCategoryId);
                    FormToObject(category);
                    category = _categoryService.Update<Category, Category, CategoryValidator>(category);
                }
                else
                {
                    category = new Category();
                    FormToObject(category);
                    category = _categoryService.Add<Category, Category, CategoryValidator>(category);
                }
                tabControlRegister.SelectedTab = tabPageList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            categories = _categoryService.Get<CategoryViewModel>().ToList();
            dataGridViewList.DataSource = categories;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            _selectedCategoryId = (int)record?.Cells["Id"].Value;
            nameTxt.Text = record?.Cells["Name"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControlRegister.SelectedTab = tabPageList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
