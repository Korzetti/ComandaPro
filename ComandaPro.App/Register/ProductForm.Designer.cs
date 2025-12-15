namespace ComandaPro.App.Register
{
    partial class ProductForm
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
            nameTxt = new ReaLTaiizor.Controls.HopeTextBox();
            categoryCbo = new ReaLTaiizor.Controls.HopeComboBox();
            priceTxt = new ReaLTaiizor.Controls.HopeTextBox();
            descriptionTxt = new ReaLTaiizor.Controls.HopeTextBox();
            tabPageList.SuspendLayout();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(descriptionTxt);
            tabPageRegister.Controls.Add(priceTxt);
            tabPageRegister.Controls.Add(categoryCbo);
            tabPageRegister.Controls.Add(nameTxt);
            tabPageRegister.Controls.SetChildIndex(nameTxt, 0);
            tabPageRegister.Controls.SetChildIndex(categoryCbo, 0);
            tabPageRegister.Controls.SetChildIndex(priceTxt, 0);
            tabPageRegister.Controls.SetChildIndex(descriptionTxt, 0);
            // 
            // nameTxt
            // 
            nameTxt.BackColor = Color.White;
            nameTxt.BaseColor = Color.FromArgb(44, 55, 66);
            nameTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            nameTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            nameTxt.Font = new Font("Segoe UI", 12F);
            nameTxt.ForeColor = Color.FromArgb(48, 49, 51);
            nameTxt.Hint = "Product Name";
            nameTxt.Location = new Point(152, 266);
            nameTxt.MaxLength = 32767;
            nameTxt.Multiline = false;
            nameTxt.Name = "nameTxt";
            nameTxt.PasswordChar = '\0';
            nameTxt.ScrollBars = ScrollBars.None;
            nameTxt.SelectedText = "";
            nameTxt.SelectionLength = 0;
            nameTxt.SelectionStart = 0;
            nameTxt.Size = new Size(742, 38);
            nameTxt.TabIndex = 2;
            nameTxt.TabStop = false;
            nameTxt.UseSystemPasswordChar = false;
            // 
            // categoryCbo
            // 
            categoryCbo.DrawMode = DrawMode.OwnerDrawFixed;
            categoryCbo.FlatStyle = FlatStyle.Flat;
            categoryCbo.Font = new Font("Segoe UI", 12F);
            categoryCbo.FormattingEnabled = true;
            categoryCbo.ItemHeight = 30;
            categoryCbo.Location = new Point(943, 266);
            categoryCbo.Name = "categoryCbo";
            categoryCbo.Size = new Size(121, 36);
            categoryCbo.TabIndex = 3;
            // 
            // priceTxt
            // 
            priceTxt.BackColor = Color.White;
            priceTxt.BaseColor = Color.FromArgb(44, 55, 66);
            priceTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            priceTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            priceTxt.Font = new Font("Segoe UI", 12F);
            priceTxt.ForeColor = Color.FromArgb(48, 49, 51);
            priceTxt.Hint = "Price";
            priceTxt.Location = new Point(943, 328);
            priceTxt.MaxLength = 32767;
            priceTxt.Multiline = false;
            priceTxt.Name = "priceTxt";
            priceTxt.PasswordChar = '\0';
            priceTxt.ScrollBars = ScrollBars.None;
            priceTxt.SelectedText = "";
            priceTxt.SelectionLength = 0;
            priceTxt.SelectionStart = 0;
            priceTxt.Size = new Size(121, 38);
            priceTxt.TabIndex = 4;
            priceTxt.TabStop = false;
            priceTxt.UseSystemPasswordChar = false;
            // 
            // descriptionTxt
            // 
            descriptionTxt.BackColor = Color.White;
            descriptionTxt.BaseColor = Color.FromArgb(44, 55, 66);
            descriptionTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            descriptionTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            descriptionTxt.Font = new Font("Segoe UI", 12F);
            descriptionTxt.ForeColor = Color.FromArgb(48, 49, 51);
            descriptionTxt.Hint = "Description (Optional)";
            descriptionTxt.Location = new Point(152, 328);
            descriptionTxt.MaxLength = 32767;
            descriptionTxt.Multiline = false;
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.PasswordChar = '\0';
            descriptionTxt.ScrollBars = ScrollBars.None;
            descriptionTxt.SelectedText = "";
            descriptionTxt.SelectionLength = 0;
            descriptionTxt.SelectionStart = 0;
            descriptionTxt.Size = new Size(742, 38);
            descriptionTxt.TabIndex = 5;
            descriptionTxt.TabStop = false;
            descriptionTxt.UseSystemPasswordChar = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 784);
            Name = "ProductForm";
            Text = "ProductForm";
            tabPageList.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox priceTxt;
        private ReaLTaiizor.Controls.HopeComboBox categoryCbo;
        private ReaLTaiizor.Controls.HopeTextBox nameTxt;
        private ReaLTaiizor.Controls.HopeTextBox descriptionTxt;
    }
}