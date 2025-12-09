namespace ComandaPro.App.Others
{
    partial class Login
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
            cancelPb = new PictureBox();
            lostPanel1 = new ReaLTaiizor.Controls.LostPanel();
            crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            button1 = new ReaLTaiizor.Controls.Button();
            passwordTxt = new ReaLTaiizor.Controls.HopeTextBox();
            emailTxt = new ReaLTaiizor.Controls.HopeTextBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cancelPb).BeginInit();
            lostPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cancelPb
            // 
            cancelPb.Image = Properties.Resources.close;
            cancelPb.Location = new Point(686, 12);
            cancelPb.Name = "cancelPb";
            cancelPb.Size = new Size(47, 44);
            cancelPb.SizeMode = PictureBoxSizeMode.StretchImage;
            cancelPb.TabIndex = 0;
            cancelPb.TabStop = false;
            cancelPb.Click += cancelPb_Click;
            cancelPb.MouseEnter += cancelPb_MouseEnter;
            cancelPb.MouseLeave += cancelPb_MouseLeave;
            // 
            // lostPanel1
            // 
            lostPanel1.BackColor = Color.White;
            lostPanel1.Controls.Add(crownLabel3);
            lostPanel1.Controls.Add(crownLabel2);
            lostPanel1.Controls.Add(button1);
            lostPanel1.Controls.Add(passwordTxt);
            lostPanel1.Controls.Add(emailTxt);
            lostPanel1.Controls.Add(crownLabel1);
            lostPanel1.Font = new Font("Segoe UI", 12F);
            lostPanel1.ForeColor = Color.White;
            lostPanel1.Location = new Point(208, 38);
            lostPanel1.Name = "lostPanel1";
            lostPanel1.Padding = new Padding(5);
            lostPanel1.ShowText = true;
            lostPanel1.Size = new Size(329, 396);
            lostPanel1.TabIndex = 1;
            // 
            // crownLabel3
            // 
            crownLabel3.AutoSize = true;
            crownLabel3.BackColor = Color.Transparent;
            crownLabel3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownLabel3.ForeColor = Color.FromArgb(234, 88, 12);
            crownLabel3.Location = new Point(189, 355);
            crownLabel3.Name = "crownLabel3";
            crownLabel3.Size = new Size(93, 18);
            crownLabel3.TabIndex = 4;
            crownLabel3.Text = "Cadastre-se";
            crownLabel3.Click += crownLabel3_Click;
            crownLabel3.MouseEnter += crownLabel3_MouseEnter;
            crownLabel3.MouseLeave += crownLabel3_MouseLeave;
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownLabel2.ForeColor = Color.Black;
            crownLabel2.Location = new Point(39, 355);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(153, 18);
            crownLabel2.TabIndex = 2;
            crownLabel2.Text = "Não tem uma conta?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BorderColor = Color.Empty;
            button1.EnteredBorderColor = Color.FromArgb(64, 64, 64);
            button1.EnteredColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(234, 88, 12);
            button1.Location = new Point(110, 291);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(64, 64, 64);
            button1.PressedColor = Color.FromArgb(64, 64, 64);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.TextAlignment = StringAlignment.Center;
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
            passwordTxt.Location = new Point(39, 237);
            passwordTxt.MaxLength = 32767;
            passwordTxt.Multiline = false;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '\0';
            passwordTxt.ScrollBars = ScrollBars.None;
            passwordTxt.SelectedText = "";
            passwordTxt.SelectionLength = 0;
            passwordTxt.SelectionStart = 0;
            passwordTxt.Size = new Size(256, 38);
            passwordTxt.TabIndex = 2;
            passwordTxt.TabStop = false;
            passwordTxt.UseSystemPasswordChar = false;
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
            emailTxt.Location = new Point(39, 181);
            emailTxt.MaxLength = 32767;
            emailTxt.Multiline = false;
            emailTxt.Name = "emailTxt";
            emailTxt.PasswordChar = '\0';
            emailTxt.ScrollBars = ScrollBars.None;
            emailTxt.SelectedText = "";
            emailTxt.SelectionLength = 0;
            emailTxt.SelectionStart = 0;
            emailTxt.Size = new Size(256, 38);
            emailTxt.TabIndex = 1;
            emailTxt.TabStop = false;
            emailTxt.UseSystemPasswordChar = false;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.BackColor = Color.White;
            crownLabel1.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownLabel1.ForeColor = Color.Black;
            crownLabel1.Location = new Point(80, 131);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(172, 31);
            crownLabel1.TabIndex = 0;
            crownLabel1.Text = "ComandaPro";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.restaurant;
            pictureBox1.Location = new Point(328, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            BackColor = Color.FromArgb(234, 88, 12);
            ClientSize = new Size(745, 472);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(lostPanel1);
            Controls.Add(cancelPb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)cancelPb).EndInit();
            lostPanel1.ResumeLayout(false);
            lostPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cancelPb;
        private ReaLTaiizor.Controls.LostPanel lostPanel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.HopeTextBox passwordTxt;
        private ReaLTaiizor.Controls.HopeTextBox emailTxt;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
    }
}