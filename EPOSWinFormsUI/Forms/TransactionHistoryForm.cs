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

            UpdateData();

            ShoppingCart.TotalChanged += new ShoppingCartUserControl.TotalChangedEvent(TotalChanged);
        }

        private void UpdateData()
        {
            var transactions = TransactionsDataAccess.Load();

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
    }
}
