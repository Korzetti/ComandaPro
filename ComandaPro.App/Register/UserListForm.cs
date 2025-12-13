using ComandaPro.App.Base;
using ComandaPro.App.ViewModel;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using ComandaPro.Service.Validators;
using ReaLTaiizor.Controls;

namespace ComandaPro.App.Register
{
    public partial class UserListForm : AdminBaseForm
    {
        private IBaseService<User> _userService;
        private List<UserViewModel>? users;

        private int _selectedUserId;
        public UserListForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void FormToObject(User user)
        {
            user.Name = nameTxt.Text;
            user.Telephone = phoneTxt.Text;
            user.Address = addressTxt.Text;
            user.Document = documentTxt.Text;
            user.Email = emailTxt.Text;
            user.Password = passwordTxt.Text;
            
            switch (docTypeCbo.SelectedIndex)
            {
                case 0:
                    user.UserType = User.Type.Customer;
                    break;
                case 1:
                    user.UserType = User.Type.Restaurant;
                    break;
                case 2:
                    user.UserType = User.Type.Admin;
                    break;
            }
        }

        protected override void Save()
        {
            try
            {
                User user;

                if (IsEditMode)
                {
                    user = _userService.GetById<User>(_selectedUserId);
                    FormToObject(user);
                    user = _userService.Update<User, User, UserValidator>(user);
                }
                else
                {
                    user = new User();
                    FormToObject(user);
                    user = _userService.Add<User, User, UserValidator>(user);
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
                _userService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            users = _userService.Get<UserViewModel>().ToList();
            dataGridViewList.DataSource = users;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            _selectedUserId = (int)record?.Cells["Id"].Value;
            nameTxt.Text = record?.Cells["Name"].Value.ToString();
            emailTxt.Text = record?.Cells["Email"].Value.ToString();
            passwordTxt.Text = record?.Cells["Password"].Value.ToString();
            addressTxt.Text = record?.Cells["Address"].Value.ToString();
            documentTxt.Text = record?.Cells["Document"].Value.ToString();
            phoneTxt.Text = record?.Cells["Telephone"].Value.ToString();
            docTypeCbo.SelectedIndex = (int)record?.Cells["UserType"].Value;
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
