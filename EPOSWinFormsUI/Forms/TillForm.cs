using EPOSLibrary;
using EPOSLibrary.DataAccess;
using EPOSLibrary.Models;
using EPOSWinFormsUI.Forms;
using EPOSWinFormsUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOSWinFormsUI
{
    public partial class TillForm : Form
    {
        private decimal total;
        public decimal Total
        {
            get { return total; }
            set 
            { 
                total = value;
                TotalTextbox.Text = total.ToString("C2");
            }
        }


        public TillForm()
        {
            InitializeComponent();


            ProductsTabs.ProductClicked += new ProductsTabsUserControl.ProductClickedEvent(AddToBasket);
            ShoppingCart.TotalChanged += new ShoppingCartUserControl.TotalChangedEvent(TotalChanged);

            ShoppingCart.Clear();
        }

        private void AddToBasket(object sender, ProductClickedEventArgs e)
        {
            ShoppingCart.Add(e.Product);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int? itemToRemove = ShoppingCart.GetSelectedID();
            if (itemToRemove != null) // Make sure that an item has actually been selected
            {
                ShoppingCart.Remove((int)itemToRemove); // Remove the item
            }
            else
            {
                MessageBox.Show("No item has been selected");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ShoppingCart.Clear();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (!ShoppingCart.IsEmpty())
            {
                Forms.PaymentForm paymentForm = new Forms.PaymentForm
                {
                    PaymentDue = Total
                };
                paymentForm.PaymentMade += new Forms.PaymentForm.PaymentEvent(PaymentMade);
                paymentForm.StartPosition = FormStartPosition.CenterParent;
                paymentForm.ShowDialog();
            }
        }

        private void PaymentMade(object sender, PaymentEventArgs e)
        {
            if (e.Success == true)
            {
                // Save the transaction

                // TODO - Use SQL transaction processing or a more advanced query

                TransactionModel transaction = new TransactionModel
                {
                    Date = DateTime.Now.ToString(),
                    Total = Total,
                    Change = e.Change,
                    PaymentMethod = e.PaymentType,
                    EmployeeUsername = EPOSLibrary.LoginSystem.Session.Employee.EmployeeUsername
                };
                transaction = TransactionsDataAccess.Save(transaction);


                foreach (CartItemModel cartItem in ShoppingCart.GetCartItems())
                {
                    TransactionItemModel transactionItem = new TransactionItemModel
                    {
                        TransactionID = transaction.TransactionID,
                        ProductID = cartItem.Product.ProductID,
                        Quantity = cartItem.Quantity,
                        CurrentUnitPrice = cartItem.UnitPrice
                    };

                    TransactionItemsDataAccess.Save(transactionItem);
                }
            }

            ShoppingCart.Clear();
        }

        private void TotalChanged(object sender, TotalChangedEventArgs e)
        {
            Total = e.Total;
        }
    }
}
