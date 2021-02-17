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
        }

        private void ApplyPerms()
        {
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
            TransactionsDataGridView.Columns["Total"].DefaultCellStyle.Format = "C2";
            TransactionsDataGridView.Columns["Change"].DefaultCellStyle.Format = "C2";
        }

        private void TotalChanged(object sender, TotalChangedEventArgs e)
        {
            TotalTextbox.Text = e.Total.ToString("C2");
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ShoppingCart.Clear();

            if (TransactionsDataGridView.SelectedRows.Count == 1)
            {
                int transactionID = int.Parse(TransactionsDataGridView.SelectedRows[0].Cells["TransactionID"].Value.ToString());
                List<TransactionItemModel> transactionItems = TransactionItemsDataAccess.Load(transactionID);

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
