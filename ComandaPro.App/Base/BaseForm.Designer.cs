namespace ComandaPro.App.Base
{
    partial class BaseForm
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
            lostPanel2 = new ReaLTaiizor.Controls.LostPanel();
            SuspendLayout();
            // 
            // lostPanel2
            // 
            lostPanel2.BackColor = Color.White;
            lostPanel2.Font = new Font("Segoe UI", 12F);
            lostPanel2.ForeColor = Color.White;
            lostPanel2.Location = new Point(236, 27);
            lostPanel2.Name = "lostPanel2";
            lostPanel2.Padding = new Padding(5);
            lostPanel2.ShowText = true;
            lostPanel2.Size = new Size(329, 396);
            lostPanel2.TabIndex = 4;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 88, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(lostPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            Text = "BaseForm";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.LostPanel lostPanel2;
    }
}