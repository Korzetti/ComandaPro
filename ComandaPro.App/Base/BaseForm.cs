using ReaLTaiizor.Controls;
using System.Runtime.InteropServices;

namespace ComandaPro.App.Base
{
    public partial class BaseForm : Form
    {
  
        #region Variables
        protected bool IsEditMode = false;
        #endregion

        #region Constructor
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events (Botões)

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PopulateGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tabControlRegister.SelectedTab = tabPageRegister;
            ClearFields();
            IsEditMode = false;
            tabPageRegister.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                IsEditMode = true;
                var row = dataGridViewList.SelectedRows[0];
                GridToForm(row); 
                tabControlRegister.SelectedTab = tabPageRegister; 
                tabPageRegister.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um registro para editar!", "ComandaPro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            tabControlRegister.SelectedTab = tabPageList;    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "ComandaPro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (int.TryParse(dataGridViewList.SelectedRows[0].Cells["Id"].Value.ToString(), out int id))
                    {
                        Delete(id);
                        PopulateGrid(); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir!", "ComandaPro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPageList_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        #endregion

        #region Virtual Methods 
        protected virtual void ClearFields()
        {
            IsEditMode = false;
            foreach (Control control in tabPageRegister.Controls)
            {
                if (control is MaterialTextBoxEdit txt) txt.Clear();
                if (control is MaterialMaskedTextBox msk) msk.Clear();
            }
        }

        protected virtual void Save() { }
        protected virtual void Delete(int id) { }
        protected virtual void GridToForm(DataGridViewRow row) { }
        protected virtual void PopulateGrid() { }

        #endregion
    }
}

