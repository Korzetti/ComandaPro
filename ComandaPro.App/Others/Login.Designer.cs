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
            crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            ((System.ComponentModel.ISupportInitialize)cancelPb).BeginInit();
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
            // crownDockPanel1
            // 
            crownDockPanel1.BackColor = Color.White;
            crownDockPanel1.Location = new Point(208, 38);
            crownDockPanel1.Name = "crownDockPanel1";
            crownDockPanel1.Size = new Size(329, 396);
            crownDockPanel1.TabIndex = 1;
            // 
            // Login
            // 
            BackColor = Color.FromArgb(234, 88, 12);
            ClientSize = new Size(745, 472);
            ControlBox = false;
            Controls.Add(crownDockPanel1);
            Controls.Add(cancelPb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)cancelPb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cancelPb;
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
    }
}