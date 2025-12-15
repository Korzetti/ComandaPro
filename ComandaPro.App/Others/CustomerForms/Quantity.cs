namespace ComandaPro.App.Others.CustomerForms
{
    public partial class Quantity : Form
    {
        public int returnQnt { get; set; }
        public Quantity()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void carrinhoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                returnQnt = int.Parse(qntTxt.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.", "Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void closeLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
