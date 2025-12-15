namespace ComandaPro.App.Base
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEdit = new ReaLTaiizor.Controls.Button();
            btnDelete = new ReaLTaiizor.Controls.Button();
            tabControlRegister = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageList = new TabPage();
            btnNew = new ReaLTaiizor.Controls.Button();
            dataGridViewList = new DataGridView();
            tabPageRegister = new TabPage();
            btnSave = new ReaLTaiizor.Controls.Button();
            btnCancel = new ReaLTaiizor.Controls.Button();
            tabControlRegister.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BorderColor = Color.FromArgb(32, 34, 37);
            btnEdit.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnEdit.EnteredColor = Color.FromArgb(32, 34, 37);
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F);
            btnEdit.Image = null;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.InactiveColor = Color.FromArgb(32, 34, 37);
            btnEdit.Location = new Point(932, 692);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnEdit.PressedColor = Color.FromArgb(165, 37, 37);
            btnEdit.Size = new Size(120, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderColor = Color.FromArgb(32, 34, 37);
            btnDelete.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnDelete.EnteredColor = Color.FromArgb(32, 34, 37);
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Image = null;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.InactiveColor = Color.FromArgb(32, 34, 37);
            btnDelete.Location = new Point(1080, 692);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnDelete.PressedColor = Color.FromArgb(165, 37, 37);
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
            // 
            // tabControlRegister
            // 
            tabControlRegister.Controls.Add(tabPageList);
            tabControlRegister.Controls.Add(tabPageRegister);
            tabControlRegister.Depth = 0;
            tabControlRegister.Dock = DockStyle.Fill;
            tabControlRegister.Location = new Point(0, 0);
            tabControlRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(1219, 784);
            tabControlRegister.TabIndex = 4;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(btnNew);
            tabPageList.Controls.Add(dataGridViewList);
            tabPageList.Controls.Add(btnDelete);
            tabPageList.Controls.Add(btnEdit);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(1211, 756);
            tabPageList.TabIndex = 0;
            tabPageList.Text = "tabPage1";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Transparent;
            btnNew.BorderColor = Color.FromArgb(32, 34, 37);
            btnNew.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnNew.EnteredColor = Color.FromArgb(32, 34, 37);
            btnNew.Font = new Font("Microsoft Sans Serif", 12F);
            btnNew.Image = null;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.InactiveColor = Color.FromArgb(32, 34, 37);
            btnNew.Location = new Point(793, 692);
            btnNew.Name = "btnNew";
            btnNew.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnNew.PressedColor = Color.FromArgb(165, 37, 37);
            btnNew.Size = new Size(120, 40);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.TextAlignment = StringAlignment.Center;
            btnNew.Click += btnNew_Click;
            // 
            // dataGridViewList
            // 
            dataGridViewList.AllowUserToAddRows = false;
            dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Dock = DockStyle.Top;
            dataGridViewList.Location = new Point(3, 3);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.ReadOnly = true;
            dataGridViewList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewList.Size = new Size(1205, 562);
            dataGridViewList.TabIndex = 5;
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(btnSave);
            tabPageRegister.Controls.Add(btnCancel);
            tabPageRegister.Location = new Point(4, 24);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3);
            tabPageRegister.Size = new Size(1211, 756);
            tabPageRegister.TabIndex = 1;
            tabPageRegister.Text = "tabPage2";
            tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BorderColor = Color.FromArgb(32, 34, 37);
            btnSave.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSave.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Image = null;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSave.Location = new Point(1064, 697);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSave.PressedColor = Color.FromArgb(165, 37, 37);
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.FromArgb(32, 34, 37);
            btnCancel.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnCancel.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancel.Image = null;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCancel.Location = new Point(928, 697);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancel.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1219, 784);
            Controls.Add(tabControlRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            Text = "BaseForm";
            tabControlRegister.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button btnEdit;
        private ReaLTaiizor.Controls.Button btnDelete;
        private ReaLTaiizor.Controls.Button btnSave;
        private ReaLTaiizor.Controls.Button btnCancel;
        public ReaLTaiizor.Controls.Button btnNew;
        public TabPage tabPageList;
        public DataGridView dataGridViewList;
        protected TabPage tabPageRegister;
        public ReaLTaiizor.Controls.MaterialTabControl tabControlRegister;
    }
}