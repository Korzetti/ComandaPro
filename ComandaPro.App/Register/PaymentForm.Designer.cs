namespace ComandaPro.App.Register
{
    partial class PaymentForm
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
            lostBorderPanel1 = new ReaLTaiizor.Controls.LostBorderPanel();
            closeLbl = new PictureBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            paymentCbo = new ReaLTaiizor.Controls.HopeComboBox();
            crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            paymentBtn = new ReaLTaiizor.Controls.Button();
            lostBorderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeLbl).BeginInit();
            SuspendLayout();
            // 
            // lostBorderPanel1
            // 
            lostBorderPanel1.BackColor = Color.FromArgb(64, 64, 64);
            lostBorderPanel1.BorderColor = Color.FromArgb(64, 64, 64);
            lostBorderPanel1.Controls.Add(closeLbl);
            lostBorderPanel1.Dock = DockStyle.Top;
            lostBorderPanel1.Font = new Font("Segoe UI", 12F);
            lostBorderPanel1.ForeColor = Color.White;
            lostBorderPanel1.Location = new Point(0, 0);
            lostBorderPanel1.Name = "lostBorderPanel1";
            lostBorderPanel1.Padding = new Padding(5);
            lostBorderPanel1.ShowText = true;
            lostBorderPanel1.Size = new Size(410, 31);
            lostBorderPanel1.TabIndex = 10;
            // 
            // closeLbl
            // 
            closeLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeLbl.Image = Properties.Resources.close;
            closeLbl.Location = new Point(380, 4);
            closeLbl.Name = "closeLbl";
            closeLbl.Size = new Size(21, 23);
            closeLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            closeLbl.TabIndex = 10;
            closeLbl.TabStop = false;
            closeLbl.Click += closeLbl_Click;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel1.ForeColor = Color.Black;
            crownLabel1.Location = new Point(22, 69);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(219, 31);
            crownLabel1.TabIndex = 12;
            crownLabel1.Text = "TOTAL PRICE:";
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel2.ForeColor = Color.Black;
            crownLabel2.Location = new Point(233, 69);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(0, 31);
            crownLabel2.TabIndex = 13;
            // 
            // paymentCbo
            // 
            paymentCbo.DrawMode = DrawMode.OwnerDrawFixed;
            paymentCbo.FlatStyle = FlatStyle.Flat;
            paymentCbo.Font = new Font("Segoe UI", 12F);
            paymentCbo.FormattingEnabled = true;
            paymentCbo.ItemHeight = 30;
            paymentCbo.Items.AddRange(new object[] { "PIX", "CREDIT", "DEBIT", "CASH" });
            paymentCbo.Location = new Point(130, 173);
            paymentCbo.Name = "paymentCbo";
            paymentCbo.Size = new Size(121, 36);
            paymentCbo.TabIndex = 14;
            // 
            // crownLabel3
            // 
            crownLabel3.AutoSize = true;
            crownLabel3.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel3.ForeColor = Color.Black;
            crownLabel3.Location = new Point(105, 144);
            crownLabel3.Name = "crownLabel3";
            crownLabel3.Size = new Size(177, 23);
            crownLabel3.TabIndex = 15;
            crownLabel3.Text = "Payment Method";
            // 
            // paymentBtn
            // 
            paymentBtn.BackColor = Color.Transparent;
            paymentBtn.BorderColor = Color.FromArgb(32, 34, 37);
            paymentBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            paymentBtn.EnteredColor = Color.FromArgb(32, 34, 37);
            paymentBtn.Font = new Font("Microsoft Sans Serif", 12F);
            paymentBtn.Image = null;
            paymentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            paymentBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            paymentBtn.Location = new Point(131, 243);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            paymentBtn.PressedColor = Color.FromArgb(165, 37, 37);
            paymentBtn.Size = new Size(120, 40);
            paymentBtn.TabIndex = 16;
            paymentBtn.Text = "Pay";
            paymentBtn.TextAlignment = StringAlignment.Center;
            paymentBtn.Click += paymentBtn_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(410, 308);
            Controls.Add(paymentBtn);
            Controls.Add(crownLabel3);
            Controls.Add(paymentCbo);
            Controls.Add(crownLabel2);
            Controls.Add(crownLabel1);
            Controls.Add(lostBorderPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            lostBorderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeLbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel1;
        private PictureBox closeLbl;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.HopeComboBox paymentCbo;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        public ReaLTaiizor.Controls.Button paymentBtn;
    }
}