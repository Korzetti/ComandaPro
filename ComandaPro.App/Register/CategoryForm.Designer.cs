namespace ComandaPro.App.Register
{
    partial class CategoryForm
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
            tabPageList.SuspendLayout();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(nameTxt);
            tabPageRegister.Controls.SetChildIndex(nameTxt, 0);
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
            nameTxt.Location = new Point(88, 44);
            nameTxt.MaxLength = 32767;
            nameTxt.Multiline = false;
            nameTxt.Name = "nameTxt";
            nameTxt.PasswordChar = '\0';
            nameTxt.ScrollBars = ScrollBars.None;
            nameTxt.SelectedText = "";
            nameTxt.SelectionLength = 0;
            nameTxt.SelectionStart = 0;
            nameTxt.Size = new Size(314, 38);
            nameTxt.TabIndex = 2;
            nameTxt.TabStop = false;
            nameTxt.UseSystemPasswordChar = false;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 422);
            Name = "CategoryForm";
            Text = "CategoryForm";
            tabPageList.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox nameTxt;
    }
}