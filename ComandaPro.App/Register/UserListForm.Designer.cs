namespace ComandaPro.App.Register
{
    partial class UserListForm
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
            emailTxt = new ReaLTaiizor.Controls.HopeTextBox();
            passwordTxt = new ReaLTaiizor.Controls.HopeTextBox();
            phoneTxt = new ReaLTaiizor.Controls.HopeTextBox();
            addressTxt = new ReaLTaiizor.Controls.HopeTextBox();
            documentTxt = new ReaLTaiizor.Controls.HopeTextBox();
            docTypeCbo = new ReaLTaiizor.Controls.HopeComboBox();
            tabPageList.SuspendLayout();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageList
            // 
            tabPageList.Size = new Size(498, 394);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(docTypeCbo);
            tabPageRegister.Controls.Add(documentTxt);
            tabPageRegister.Controls.Add(addressTxt);
            tabPageRegister.Controls.Add(phoneTxt);
            tabPageRegister.Controls.Add(passwordTxt);
            tabPageRegister.Controls.Add(emailTxt);
            tabPageRegister.Controls.Add(nameTxt);
            tabPageRegister.Controls.SetChildIndex(nameTxt, 0);
            tabPageRegister.Controls.SetChildIndex(emailTxt, 0);
            tabPageRegister.Controls.SetChildIndex(passwordTxt, 0);
            tabPageRegister.Controls.SetChildIndex(phoneTxt, 0);
            tabPageRegister.Controls.SetChildIndex(addressTxt, 0);
            tabPageRegister.Controls.SetChildIndex(documentTxt, 0);
            tabPageRegister.Controls.SetChildIndex(docTypeCbo, 0);
            // 
            // nameTxt
            // 
            nameTxt.BackColor = Color.White;
            nameTxt.BaseColor = Color.FromArgb(44, 55, 66);
            nameTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            nameTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            nameTxt.Font = new Font("Segoe UI", 12F);
            nameTxt.ForeColor = Color.FromArgb(48, 49, 51);
            nameTxt.Hint = "Name";
            nameTxt.Location = new Point(334, 189);
            nameTxt.MaxLength = 32767;
            nameTxt.Multiline = false;
            nameTxt.Name = "nameTxt";
            nameTxt.PasswordChar = '\0';
            nameTxt.ScrollBars = ScrollBars.None;
            nameTxt.SelectedText = "";
            nameTxt.SelectionLength = 0;
            nameTxt.SelectionStart = 0;
            nameTxt.Size = new Size(458, 38);
            nameTxt.TabIndex = 2;
            nameTxt.TabStop = false;
            nameTxt.UseSystemPasswordChar = false;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.White;
            emailTxt.BaseColor = Color.FromArgb(44, 55, 66);
            emailTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            emailTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            emailTxt.Font = new Font("Segoe UI", 12F);
            emailTxt.ForeColor = Color.FromArgb(48, 49, 51);
            emailTxt.Hint = "your@email.com";
            emailTxt.Location = new Point(334, 365);
            emailTxt.MaxLength = 32767;
            emailTxt.Multiline = false;
            emailTxt.Name = "emailTxt";
            emailTxt.PasswordChar = '\0';
            emailTxt.ScrollBars = ScrollBars.None;
            emailTxt.SelectedText = "";
            emailTxt.SelectionLength = 0;
            emailTxt.SelectionStart = 0;
            emailTxt.Size = new Size(458, 38);
            emailTxt.TabIndex = 3;
            emailTxt.TabStop = false;
            emailTxt.UseSystemPasswordChar = false;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.White;
            passwordTxt.BaseColor = Color.FromArgb(44, 55, 66);
            passwordTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            passwordTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            passwordTxt.Font = new Font("Segoe UI", 12F);
            passwordTxt.ForeColor = Color.FromArgb(48, 49, 51);
            passwordTxt.Hint = "•••••••••";
            passwordTxt.Location = new Point(334, 409);
            passwordTxt.MaxLength = 32767;
            passwordTxt.Multiline = false;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '\0';
            passwordTxt.ScrollBars = ScrollBars.None;
            passwordTxt.SelectedText = "";
            passwordTxt.SelectionLength = 0;
            passwordTxt.SelectionStart = 0;
            passwordTxt.Size = new Size(458, 38);
            passwordTxt.TabIndex = 4;
            passwordTxt.TabStop = false;
            passwordTxt.UseSystemPasswordChar = false;
            // 
            // phoneTxt
            // 
            phoneTxt.BackColor = Color.White;
            phoneTxt.BaseColor = Color.FromArgb(44, 55, 66);
            phoneTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            phoneTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            phoneTxt.Font = new Font("Segoe UI", 12F);
            phoneTxt.ForeColor = Color.FromArgb(48, 49, 51);
            phoneTxt.Hint = "Telephone";
            phoneTxt.Location = new Point(334, 233);
            phoneTxt.MaxLength = 32767;
            phoneTxt.Multiline = false;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.PasswordChar = '\0';
            phoneTxt.ScrollBars = ScrollBars.None;
            phoneTxt.SelectedText = "";
            phoneTxt.SelectionLength = 0;
            phoneTxt.SelectionStart = 0;
            phoneTxt.Size = new Size(458, 38);
            phoneTxt.TabIndex = 5;
            phoneTxt.TabStop = false;
            phoneTxt.UseSystemPasswordChar = false;
            // 
            // addressTxt
            // 
            addressTxt.BackColor = Color.White;
            addressTxt.BaseColor = Color.FromArgb(44, 55, 66);
            addressTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            addressTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            addressTxt.Font = new Font("Segoe UI", 12F);
            addressTxt.ForeColor = Color.FromArgb(48, 49, 51);
            addressTxt.Hint = "Address";
            addressTxt.Location = new Point(334, 277);
            addressTxt.MaxLength = 32767;
            addressTxt.Multiline = false;
            addressTxt.Name = "addressTxt";
            addressTxt.PasswordChar = '\0';
            addressTxt.ScrollBars = ScrollBars.None;
            addressTxt.SelectedText = "";
            addressTxt.SelectionLength = 0;
            addressTxt.SelectionStart = 0;
            addressTxt.Size = new Size(458, 38);
            addressTxt.TabIndex = 6;
            addressTxt.TabStop = false;
            addressTxt.UseSystemPasswordChar = false;
            // 
            // documentTxt
            // 
            documentTxt.BackColor = Color.White;
            documentTxt.BaseColor = Color.FromArgb(44, 55, 66);
            documentTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            documentTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            documentTxt.Font = new Font("Segoe UI", 12F);
            documentTxt.ForeColor = Color.FromArgb(48, 49, 51);
            documentTxt.Hint = "Document";
            documentTxt.Location = new Point(334, 321);
            documentTxt.MaxLength = 32767;
            documentTxt.Multiline = false;
            documentTxt.Name = "documentTxt";
            documentTxt.PasswordChar = '\0';
            documentTxt.ScrollBars = ScrollBars.None;
            documentTxt.SelectedText = "";
            documentTxt.SelectionLength = 0;
            documentTxt.SelectionStart = 0;
            documentTxt.Size = new Size(330, 38);
            documentTxt.TabIndex = 7;
            documentTxt.TabStop = false;
            documentTxt.UseSystemPasswordChar = false;
            // 
            // docTypeCbo
            // 
            docTypeCbo.DrawMode = DrawMode.OwnerDrawFixed;
            docTypeCbo.FlatStyle = FlatStyle.Flat;
            docTypeCbo.Font = new Font("Segoe UI", 12F);
            docTypeCbo.FormattingEnabled = true;
            docTypeCbo.ItemHeight = 30;
            docTypeCbo.Items.AddRange(new object[] { "CPF", "CNPJ", "Admin" });
            docTypeCbo.Location = new Point(689, 323);
            docTypeCbo.Name = "docTypeCbo";
            docTypeCbo.Size = new Size(104, 36);
            docTypeCbo.TabIndex = 8;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 784);
            Name = "UserListForm";
            Text = "UserListForm";
            tabPageList.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox passwordTxt;
        private ReaLTaiizor.Controls.HopeTextBox emailTxt;
        private ReaLTaiizor.Controls.HopeTextBox nameTxt;
        private ReaLTaiizor.Controls.HopeTextBox phoneTxt;
        private ReaLTaiizor.Controls.HopeTextBox addressTxt;
        private ReaLTaiizor.Controls.HopeTextBox documentTxt;
        private ReaLTaiizor.Controls.HopeComboBox docTypeCbo;
    }
}