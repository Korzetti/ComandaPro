namespace ComandaPro.App.Others.RestaurantForms
{
    partial class RestaurantOrders
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
            btnAdvance = new ReaLTaiizor.Controls.Button();
            gridOrders = new DataGridView();
            btnDetails = new ReaLTaiizor.Controls.Button();
            tabControlList = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageViewOrders = new TabPage();
            tabPageViewDetails = new TabPage();
            gridDetails = new DataGridView();
            btnReturn = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)gridOrders).BeginInit();
            tabControlList.SuspendLayout();
            tabPageViewOrders.SuspendLayout();
            tabPageViewDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDetails).BeginInit();
            SuspendLayout();
            // 
            // btnAdvance
            // 
            btnAdvance.BackColor = Color.Transparent;
            btnAdvance.BorderColor = Color.FromArgb(32, 34, 37);
            btnAdvance.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnAdvance.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAdvance.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdvance.Image = null;
            btnAdvance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdvance.InactiveColor = Color.FromArgb(32, 34, 37);
            btnAdvance.Location = new Point(942, 710);
            btnAdvance.Name = "btnAdvance";
            btnAdvance.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnAdvance.PressedColor = Color.FromArgb(165, 37, 37);
            btnAdvance.Size = new Size(120, 40);
            btnAdvance.TabIndex = 9;
            btnAdvance.Text = "Next Status";
            btnAdvance.TextAlignment = StringAlignment.Center;
            btnAdvance.Click += btnAdvance_Click;
            // 
            // gridOrders
            // 
            gridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrders.Location = new Point(13, 21);
            gridOrders.Name = "gridOrders";
            gridOrders.Size = new Size(1187, 641);
            gridOrders.TabIndex = 10;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.Transparent;
            btnDetails.BorderColor = Color.FromArgb(32, 34, 37);
            btnDetails.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnDetails.EnteredColor = Color.FromArgb(32, 34, 37);
            btnDetails.Font = new Font("Microsoft Sans Serif", 12F);
            btnDetails.Image = null;
            btnDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetails.InactiveColor = Color.FromArgb(32, 34, 37);
            btnDetails.Location = new Point(1083, 710);
            btnDetails.Name = "btnDetails";
            btnDetails.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnDetails.PressedColor = Color.FromArgb(165, 37, 37);
            btnDetails.Size = new Size(120, 40);
            btnDetails.TabIndex = 11;
            btnDetails.Text = "Details";
            btnDetails.TextAlignment = StringAlignment.Center;
            btnDetails.Click += btnDetails_Click;
            // 
            // tabControlList
            // 
            tabControlList.Controls.Add(tabPageViewOrders);
            tabControlList.Controls.Add(tabPageViewDetails);
            tabControlList.Depth = 0;
            tabControlList.Dock = DockStyle.Fill;
            tabControlList.Location = new Point(0, 0);
            tabControlList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlList.Multiline = true;
            tabControlList.Name = "tabControlList";
            tabControlList.SelectedIndex = 0;
            tabControlList.Size = new Size(1219, 784);
            tabControlList.TabIndex = 12;
            // 
            // tabPageViewOrders
            // 
            tabPageViewOrders.Controls.Add(btnAdvance);
            tabPageViewOrders.Controls.Add(gridOrders);
            tabPageViewOrders.Controls.Add(btnDetails);
            tabPageViewOrders.Location = new Point(4, 24);
            tabPageViewOrders.Name = "tabPageViewOrders";
            tabPageViewOrders.Padding = new Padding(3);
            tabPageViewOrders.Size = new Size(1211, 756);
            tabPageViewOrders.TabIndex = 0;
            tabPageViewOrders.Text = "tabPage1";
            tabPageViewOrders.UseVisualStyleBackColor = true;
            // 
            // tabPageViewDetails
            // 
            tabPageViewDetails.Controls.Add(btnReturn);
            tabPageViewDetails.Controls.Add(gridDetails);
            tabPageViewDetails.Location = new Point(4, 24);
            tabPageViewDetails.Name = "tabPageViewDetails";
            tabPageViewDetails.Padding = new Padding(3);
            tabPageViewDetails.Size = new Size(1211, 756);
            tabPageViewDetails.TabIndex = 1;
            tabPageViewDetails.Text = "tabPage2";
            tabPageViewDetails.UseVisualStyleBackColor = true;
            // 
            // gridDetails
            // 
            gridDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetails.Location = new Point(13, 21);
            gridDetails.Name = "gridDetails";
            gridDetails.Size = new Size(1187, 641);
            gridDetails.TabIndex = 11;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.BorderColor = Color.FromArgb(32, 34, 37);
            btnReturn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnReturn.EnteredColor = Color.FromArgb(32, 34, 37);
            btnReturn.Font = new Font("Microsoft Sans Serif", 12F);
            btnReturn.Image = null;
            btnReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturn.InactiveColor = Color.FromArgb(32, 34, 37);
            btnReturn.Location = new Point(1083, 710);
            btnReturn.Name = "btnReturn";
            btnReturn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnReturn.PressedColor = Color.FromArgb(165, 37, 37);
            btnReturn.Size = new Size(120, 40);
            btnReturn.TabIndex = 12;
            btnReturn.Text = "Return";
            btnReturn.TextAlignment = StringAlignment.Center;
            btnReturn.Click += btnReturn_Click;
            // 
            // RestaurantOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 784);
            Controls.Add(tabControlList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestaurantOrders";
            Text = "RestaurantOrders";
            ((System.ComponentModel.ISupportInitialize)gridOrders).EndInit();
            tabControlList.ResumeLayout(false);
            tabPageViewOrders.ResumeLayout(false);
            tabPageViewDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public ReaLTaiizor.Controls.Button btnAdvance;
        private DataGridView gridOrders;
        public ReaLTaiizor.Controls.Button btnDetails;
        private ReaLTaiizor.Controls.MaterialTabControl tabControlList;
        private TabPage tabPageViewOrders;
        private TabPage tabPageViewDetails;
        private DataGridView gridDetails;
        public ReaLTaiizor.Controls.Button btnReturn;
    }
}