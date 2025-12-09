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
            // 
            // Login
            // 
            BackColor = Color.FromArgb(234, 88, 12);
            ClientSize = new Size(745, 456);
            ControlBox = false;
            Controls.Add(cancelPb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            ((System.ComponentModel.ISupportInitialize)cancelPb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cancelPb;
    }
}