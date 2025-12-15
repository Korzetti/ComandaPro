namespace ComandaPro.App.Others.CustomerForms
{
    partial class Quantity
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
            qntTxt = new ReaLTaiizor.Controls.HopeTextBox();
            qntLabel = new ReaLTaiizor.Controls.CrownLabel();
            carrinhoBtn = new ReaLTaiizor.Controls.Button();
            lostBorderPanel1 = new ReaLTaiizor.Controls.LostBorderPanel();
            closeLbl = new PictureBox();
            lostBorderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeLbl).BeginInit();
            SuspendLayout();
            // 
            // qntTxt
            // 
            qntTxt.BackColor = Color.White;
            qntTxt.BaseColor = Color.FromArgb(44, 55, 66);
            qntTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            qntTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            qntTxt.Font = new Font("Segoe UI", 12F);
            qntTxt.ForeColor = Color.FromArgb(48, 49, 51);
            qntTxt.Hint = "";
            qntTxt.Location = new Point(126, 89);
            qntTxt.MaxLength = 32767;
            qntTxt.Multiline = false;
            qntTxt.Name = "qntTxt";
            qntTxt.PasswordChar = '\0';
            qntTxt.ScrollBars = ScrollBars.None;
            qntTxt.SelectedText = "";
            qntTxt.SelectionLength = 0;
            qntTxt.SelectionStart = 0;
            qntTxt.Size = new Size(75, 38);
            qntTxt.TabIndex = 0;
            qntTxt.TabStop = false;
            qntTxt.UseSystemPasswordChar = false;
            // 
            // qntLabel
            // 
            qntLabel.AutoSize = true;
            qntLabel.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qntLabel.ForeColor = Color.White;
            qntLabel.Location = new Point(113, 38);
            qntLabel.Name = "qntLabel";
            qntLabel.Size = new Size(106, 29);
            qntLabel.TabIndex = 1;
            qntLabel.Text = "Quantity";
            // 
            // carrinhoBtn
            // 
            carrinhoBtn.BackColor = Color.Transparent;
            carrinhoBtn.BorderColor = Color.FromArgb(32, 34, 37);
            carrinhoBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            carrinhoBtn.EnteredColor = Color.FromArgb(32, 34, 37);
            carrinhoBtn.Font = new Font("Microsoft Sans Serif", 12F);
            carrinhoBtn.Image = null;
            carrinhoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            carrinhoBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            carrinhoBtn.Location = new Point(101, 158);
            carrinhoBtn.Name = "carrinhoBtn";
            carrinhoBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            carrinhoBtn.PressedColor = Color.FromArgb(165, 37, 37);
            carrinhoBtn.Size = new Size(120, 40);
            carrinhoBtn.TabIndex = 8;
            carrinhoBtn.Text = "Define";
            carrinhoBtn.TextAlignment = StringAlignment.Center;
            carrinhoBtn.Click += carrinhoBtn_Click;
            // 
            // lostBorderPanel1
            // 
            lostBorderPanel1.BackColor = Color.FromArgb(64, 64, 64);
            lostBorderPanel1.BorderColor = Color.FromArgb(64, 64, 64);
            lostBorderPanel1.Controls.Add(closeLbl);
            lostBorderPanel1.Font = new Font("Segoe UI", 12F);
            lostBorderPanel1.ForeColor = Color.White;
            lostBorderPanel1.Location = new Point(-2, -1);
            lostBorderPanel1.Name = "lostBorderPanel1";
            lostBorderPanel1.Padding = new Padding(5);
            lostBorderPanel1.ShowText = true;
            lostBorderPanel1.Size = new Size(340, 31);
            lostBorderPanel1.TabIndex = 9;
            // 
            // closeLbl
            // 
            closeLbl.Image = Properties.Resources.close;
            closeLbl.Location = new Point(309, 5);
            closeLbl.Name = "closeLbl";
            closeLbl.Size = new Size(21, 23);
            closeLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            closeLbl.TabIndex = 10;
            closeLbl.TabStop = false;
            closeLbl.Click += closeLbl_Click;
            // 
            // Quantity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(332, 228);
            Controls.Add(lostBorderPanel1);
            Controls.Add(carrinhoBtn);
            Controls.Add(qntLabel);
            Controls.Add(qntTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Quantity";
            Text = "Quantity";
            lostBorderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeLbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox qntTxt;
        private ReaLTaiizor.Controls.CrownLabel qntLabel;
        public ReaLTaiizor.Controls.Button carrinhoBtn;
        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel1;
        private PictureBox closeLbl;
    }
}