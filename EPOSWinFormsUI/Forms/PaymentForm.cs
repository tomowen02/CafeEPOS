using EPOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOSWinFormsUI.Forms
{
    public partial class PaymentForm : Form
    {
        public delegate void PaymentEvent(object sender, PaymentEventArgs e);
        public event PaymentEvent PaymentMade;

        private decimal paymentDue;
        public decimal PaymentDue
        {
            get { return paymentDue; }
            set 
            { 
                paymentDue = value;
                PaymentDueTextbox.Text = paymentDue.ToString("C2");
            }
        }

        private decimal Change;

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void Pay(string paymentType)
        {
            decimal total;

            try
            {
                total = PaymentDue - Decimal.Parse(AmountGivenTextbox.Text);
            }
            catch
            {

                MessageBox.Show("Invalid amount given");
                return;
            }

            if (total > 0)
            {
                PaymentDue = total;
                AmountGivenTextbox.Text = "";
            }
            else
            {
                // The use has pay the correct amount

                Change = -total;
                MessageBox.Show("Change due: " + (Change).ToString("C2"));

                PaymentMade(this, new PaymentEventArgs() { Success = true, Change = Change, PaymentType = paymentType });
                this.Close();
            }
        }

        private void CashButton_Click(object sender, EventArgs e)
        {
            Pay("Cash");
        }

        private void VisaButton_Click(object sender, EventArgs e)
        {
            Pay("Visa");
        }
    }

    public class PaymentEventArgs : EventArgs
    {
        public bool Success { get; set; }
        public decimal Change { get; set; }
        public string PaymentType { get; set; }

    }
}
