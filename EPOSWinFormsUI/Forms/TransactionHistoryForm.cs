using EPOSLibrary.DataAccess;
using EPOSLibrary.Models;
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

namespace EPOSWinFormsUI.Forms
{
    public partial class TransactionHistoryForm : Form
    {
        public TransactionHistoryForm()
        {
            InitializeComponent();

            ApplyPerms();

            UpdateData();

            ShoppingCart.TotalChanged += new ShoppingCartUserControl.TotalChangedEvent(TotalChanged);

            ShoppingCart.Clear();
        }

        private void ApplyPerms()
        {
            // Only users with a role ID of 2 or less (administrators and managers)
            // should be able to view the full transaction history
            if (EPOSLibrary.LoginSystem.Session.Role.RoleID > 2)
            {
                DailyOnlyCheckBox.Visible = false;
            }
        }

        private void UpdateData(bool isDailyOnly = true)
        {
            var transactions = TransactionsDataAccess.Load(isDailyOnly);

            TransactionsDataGridView.DataSource = transactions;

            TransactionsDataGridView.Columns[0].HeaderText = "ID";

            // Format the money columns to display the values in currency format
            TransactionsDataGridView.Columns["Total"].DefaultCellStyle.Format = "C2";
            TransactionsDataGridView.Columns["Change"].DefaultCellStyle.Format = "C2";
        }

        private void TotalChanged(object sender, TotalChangedEventArgs e)
        {
            // When the total price in the SHoppingCart control has been changed,
            // the textbox should be updated to display that information to the user
            TotalTextbox.Text = e.Total.ToString("C2");
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Display the order contents of the selected transaction

            ShoppingCart.Clear();

            if (TransactionsDataGridView.SelectedRows.Count == 1)
            {
                // Get all of the transactionItems objects related to the selected row
                int transactionID = int.Parse(TransactionsDataGridView.SelectedRows[0].Cells["TransactionID"].Value.ToString());
                List<TransactionItemModel> transactionItems = TransactionItemsDataAccess.Load(transactionID);

                // For each product, add it to the shopping cart,
                // along with the quantity to add
                foreach (var transItem in transactionItems)
                {
                    ProductModel product = ProductsDataAccess.LoadSingle(transItem.ProductID);
                    product.Price = transItem.CurrentUnitPrice;

                    ShoppingCart.Add(product, quantityToAdd: transItem.Quantity);
                }
            }
        }

        private void DailyOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isDaily = DailyOnlyCheckBox.Checked;

            UpdateData(isDaily);

            if (isDaily)
            {
                InfoLabel.Text = "Today's transactions are:";
            }
            else
            {
                InfoLabel.Text = "Full transaction history:";
            }
        }
    }
}
