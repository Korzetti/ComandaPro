using ComandaPro.App.Others.CustomerForms;
using ComandaPro.App.Infra;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ComandaPro.Service.Validators;

namespace ComandaPro.App.Register
{
    public partial class PaymentForm : Form
    {
        public Order savedOrder { get; set; }
        private IBaseService<Payment> _paymentService;
        
        public PaymentForm(IBaseService<Payment> paymentService)
        {
            _paymentService = paymentService;
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            crownLabel2.Text = savedOrder.TotalValue.ToString("C");
            crownLabel2.ForeColor = Color.Green;
        }

        private void closeLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            if(paymentCbo.SelectedItem != null)
            {
                Payment payment = new Payment();
                FormToObject(payment);
                _paymentService.Add<Payment, Payment, PaymentValidator>(payment);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Select a payment method!", "Comanda Pro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormToObject(Payment payment)
        {
            payment.Order = savedOrder;
            payment.PaymentMethod = paymentCbo.SelectedItem.ToString();
            payment.ValuePaid = savedOrder.TotalValue;
            payment.PaymentDate = DateTime.Now;
        }
    }
}
