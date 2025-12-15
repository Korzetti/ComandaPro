namespace ComandaPro.App.Others.CustomerForms
{
    partial class RestaurantMenu
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
            tabControlMenu = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageRestaurantSel = new TabPage();
            btnSelect = new ReaLTaiizor.Controls.Button();
            dataGridViewList = new DataGridView();
            tabPageRestaurantMenu = new TabPage();
            btnClearCart = new ReaLTaiizor.Controls.Button();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            pictureBox1 = new PictureBox();
            dataGridCart = new DataGridView();
            finishOrderBtn = new ReaLTaiizor.Controls.Button();
            dataGridProducts = new DataGridView();
            btnSelectProduct = new ReaLTaiizor.Controls.Button();
            btnCancel = new ReaLTaiizor.Controls.Button();
            tabControlMenu.SuspendLayout();
            tabPageRestaurantSel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            tabPageRestaurantMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // tabControlMenu
            // 
            tabControlMenu.Controls.Add(tabPageRestaurantSel);
            tabControlMenu.Controls.Add(tabPageRestaurantMenu);
            tabControlMenu.Depth = 0;
            tabControlMenu.Dock = DockStyle.Fill;
            tabControlMenu.Location = new Point(0, 0);
            tabControlMenu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlMenu.Multiline = true;
            tabControlMenu.Name = "tabControlMenu";
            tabControlMenu.SelectedIndex = 0;
            tabControlMenu.Size = new Size(1219, 784);
            tabControlMenu.TabIndex = 0;
            // 
            // tabPageRestaurantSel
            // 
            tabPageRestaurantSel.Controls.Add(btnSelect);
            tabPageRestaurantSel.Controls.Add(dataGridViewList);
            tabPageRestaurantSel.Location = new Point(4, 24);
            tabPageRestaurantSel.Name = "tabPageRestaurantSel";
            tabPageRestaurantSel.Padding = new Padding(3);
            tabPageRestaurantSel.Size = new Size(1211, 756);
            tabPageRestaurantSel.TabIndex = 0;
            tabPageRestaurantSel.Text = "tabPage1";
            tabPageRestaurantSel.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Transparent;
            btnSelect.BorderColor = Color.FromArgb(32, 34, 37);
            btnSelect.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSelect.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSelect.Font = new Font("Microsoft Sans Serif", 12F);
            btnSelect.Image = null;
            btnSelect.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelect.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSelect.Location = new Point(1005, 698);
            btnSelect.Name = "btnSelect";
            btnSelect.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSelect.PressedColor = Color.FromArgb(165, 37, 37);
            btnSelect.Size = new Size(120, 40);
            btnSelect.TabIndex = 6;
            btnSelect.Text = "Select";
            btnSelect.TextAlignment = StringAlignment.Center;
            btnSelect.Click += btnSelect_Click;
            // 
            // dataGridViewList
            // 
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(90, 49);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.Size = new Size(1035, 601);
            dataGridViewList.TabIndex = 0;
            // 
            // tabPageRestaurantMenu
            // 
            tabPageRestaurantMenu.Controls.Add(btnClearCart);
            tabPageRestaurantMenu.Controls.Add(crownLabel1);
            tabPageRestaurantMenu.Controls.Add(pictureBox1);
            tabPageRestaurantMenu.Controls.Add(dataGridCart);
            tabPageRestaurantMenu.Controls.Add(finishOrderBtn);
            tabPageRestaurantMenu.Controls.Add(dataGridProducts);
            tabPageRestaurantMenu.Controls.Add(btnSelectProduct);
            tabPageRestaurantMenu.Controls.Add(btnCancel);
            tabPageRestaurantMenu.Location = new Point(4, 24);
            tabPageRestaurantMenu.Name = "tabPageRestaurantMenu";
            tabPageRestaurantMenu.Padding = new Padding(3);
            tabPageRestaurantMenu.Size = new Size(1211, 756);
            tabPageRestaurantMenu.TabIndex = 1;
            tabPageRestaurantMenu.Text = "tabPage2";
            tabPageRestaurantMenu.UseVisualStyleBackColor = true;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.Transparent;
            btnClearCart.BorderColor = Color.FromArgb(32, 34, 37);
            btnClearCart.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnClearCart.EnteredColor = Color.FromArgb(32, 34, 37);
            btnClearCart.Font = new Font("Microsoft Sans Serif", 12F);
            btnClearCart.Image = null;
            btnClearCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearCart.InactiveColor = Color.Red;
            btnClearCart.Location = new Point(441, 632);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnClearCart.PressedColor = Color.FromArgb(165, 37, 37);
            btnClearCart.Size = new Size(120, 40);
            btnClearCart.TabIndex = 15;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.TextAlignment = StringAlignment.Center;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownLabel1.ForeColor = Color.Black;
            crownLabel1.Location = new Point(233, 443);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(98, 29);
            crownLabel1.TabIndex = 14;
            crownLabel1.Text = "My Cart";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shopping_cart;
            pictureBox1.Location = new Point(168, 432);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // dataGridCart
            // 
            dataGridCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCart.Location = new Point(90, 488);
            dataGridCart.Name = "dataGridCart";
            dataGridCart.Size = new Size(330, 246);
            dataGridCart.TabIndex = 12;
            // 
            // finishOrderBtn
            // 
            finishOrderBtn.BackColor = Color.Transparent;
            finishOrderBtn.BorderColor = Color.FromArgb(32, 34, 37);
            finishOrderBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            finishOrderBtn.EnteredColor = Color.FromArgb(32, 34, 37);
            finishOrderBtn.Font = new Font("Microsoft Sans Serif", 12F);
            finishOrderBtn.Image = null;
            finishOrderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            finishOrderBtn.InactiveColor = Color.FromArgb(255, 128, 128);
            finishOrderBtn.Location = new Point(441, 694);
            finishOrderBtn.Name = "finishOrderBtn";
            finishOrderBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            finishOrderBtn.PressedColor = Color.FromArgb(165, 37, 37);
            finishOrderBtn.Size = new Size(120, 40);
            finishOrderBtn.TabIndex = 11;
            finishOrderBtn.Text = "Finish Order";
            finishOrderBtn.TextAlignment = StringAlignment.Center;
            finishOrderBtn.Click += finishOrderBtn_Click;
            // 
            // dataGridProducts
            // 
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducts.Location = new Point(90, 49);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.Size = new Size(1035, 345);
            dataGridProducts.TabIndex = 9;
            // 
            // btnSelectProduct
            // 
            btnSelectProduct.BackColor = Color.Transparent;
            btnSelectProduct.BorderColor = Color.FromArgb(32, 34, 37);
            btnSelectProduct.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSelectProduct.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSelectProduct.Font = new Font("Microsoft Sans Serif", 12F);
            btnSelectProduct.Image = null;
            btnSelectProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectProduct.InactiveColor = Color.FromArgb(128, 128, 255);
            btnSelectProduct.Location = new Point(1005, 432);
            btnSelectProduct.Name = "btnSelectProduct";
            btnSelectProduct.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSelectProduct.PressedColor = Color.FromArgb(165, 37, 37);
            btnSelectProduct.Size = new Size(120, 40);
            btnSelectProduct.TabIndex = 8;
            btnSelectProduct.Text = "Select Product";
            btnSelectProduct.TextAlignment = StringAlignment.Center;
            btnSelectProduct.Click += btnSelectProduct_Click;
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
            btnCancel.Location = new Point(1005, 694);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancel.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Return";
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // RestaurantMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 784);
            Controls.Add(tabControlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestaurantMenu";
            Text = "RestaurantMenu";
            tabControlMenu.ResumeLayout(false);
            tabPageRestaurantSel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            tabPageRestaurantMenu.ResumeLayout(false);
            tabPageRestaurantMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlMenu;
        private TabPage tabPageRestaurantSel;
        private TabPage tabPageRestaurantMenu;
        private DataGridView dataGridViewList;
        public ReaLTaiizor.Controls.Button btnSelect;
        public ReaLTaiizor.Controls.Button btnCancel;
        public ReaLTaiizor.Controls.Button btnSelectProduct;
        private DataGridView dataGridProducts;
        public ReaLTaiizor.Controls.Button finishOrderBtn;
        private DataGridView dataGridCart;
        public ReaLTaiizor.Controls.Button btnClearCart;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private PictureBox pictureBox1;
    }
}