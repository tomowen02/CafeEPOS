using EPOSLibrary.DataAccess;
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
    public partial class ManageProductsForm : Form
    {

        bool isFormLoaded = false;

        public ManageProductsForm()
        {
            InitializeComponent();

            InitializeData();
        }

        private void InitializeData()
        {
            List<ProductTypeModel> productTypes = ProductTypesDataAccess.Load();
            ProductTypeComboBox.DataSource = productTypes;
            ProductTypeComboBox.DisplayMember = "ProductType";
            ProductTypeCheckBox.Checked = false;

            var products = ProductsDataAccess.Load();
            ShowProducts(products);

            ClearFilters();
        }

        private void ShowProducts(List<ProductModel> products)
        {
            ProductsDataGridView.DataSource = products;
            ProductsDataGridView.Columns["Price"].DefaultCellStyle.Format = "C2";
        }

        private void Filter()
        {
            if (isFormLoaded)
            {
                string nameFilter = NameFilterTextBox.Text;
                if (!ProductNameCheckBox.Checked)
                {
                    nameFilter = "";
                }

                int productTypeID = ((ProductTypeModel)ProductTypeComboBox.SelectedItem).ProductTypeID;
                if (!ProductTypeCheckBox.Checked)
                {
                    productTypeID = -1;
                }

                decimal minPrice;
                if (MinPriceFilterTextBox.Text == "" | !PriceCheckBox.Checked)
                {
                    minPrice = -1M;
                }
                else
                {
                    try
                    {
                        minPrice = Decimal.Parse(MinPriceFilterTextBox.Text);
                    }
                    catch (Exception)
                    {
                        minPrice = -1M;
                    }
                }
                decimal maxPrice;
                if (MaxPriceFilterTextBox.Text == "" | !PriceCheckBox.Checked)
                {
                    maxPrice = -1M;
                }
                else
                {
                    try
                    {
                        maxPrice = Decimal.Parse(MaxPriceFilterTextBox.Text);
                    }
                    catch (Exception)
                    {
                        maxPrice = -1M;
                    }
                }

                List<ProductModel> products = ProductsDataAccess.Load(nameFilter, productTypeID, minPrice, maxPrice);
                ShowProducts(products);
            }
            
        }
        private void ClearFilters()
        {
            NameFilterTextBox.Text = "";
            ProductTypeComboBox.SelectedIndex = 0;
            MinPriceFilterTextBox.Text = "";
            MaxPriceFilterTextBox.Text = "";

            ProductNameCheckBox.Checked = false;
            ProductTypeCheckBox.Checked = false;
            PriceCheckBox.Checked = false;
        }

        #region Filter controls Click events
        private void NameFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
            ProductNameCheckBox.Checked = true;
        }

        private void ProductTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
            ProductTypeCheckBox.Checked = true;
        }

        private void MinPriceFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
            PriceCheckBox.Checked = true;
        }

        private void MaxPriceFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
            PriceCheckBox.Checked = true;
        }

        private void ProductNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void ProductTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void PriceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void ClearFiltersButton_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
        #endregion

        private ProductModel GetSelectedProduct()
        {
            return (ProductModel)ProductsDataGridView.SelectedRows[0].DataBoundItem;
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            EditProductInfoForm editProductInfoForm = new EditProductInfoForm();
            editProductInfoForm.ProductGenerated += new EditProductInfoForm.ProductGeneratedEvent(NewOrEditedProduct);
            editProductInfoForm.StartPosition = FormStartPosition.CenterParent;

            try
            {
                editProductInfoForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ProductsDataGridView.SelectedRows[0].Cells["ProductID"].Value.ToString());
            ProductModel product = ProductsDataAccess.LoadSingle(id);


            EditProductInfoForm editProductInfoForm = new EditProductInfoForm(product);
            editProductInfoForm.ProductGenerated += new EditProductInfoForm.ProductGeneratedEvent(NewOrEditedProduct);
            editProductInfoForm.StartPosition = FormStartPosition.CenterParent;

            try
            {
                editProductInfoForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete product", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int productID = GetSelectedProduct().ProductID;
                    ProductsDataAccess.Delete(productID);

                    MessageBox.Show("Product has been deleted");
                }
                catch
                {

                    MessageBox.Show("Something went wrong");
                }

                InitializeData();
            }
        }

        private void NewOrEditedProduct(object sender, ProductGeneratedEventArgs e)
        {
            if (e.IsNewItem)
            {
                ProductModel product = e.Product;
                ProductsDataAccess.Save(product);

                MessageBox.Show("New item has been created");
            }
            else
            {
                ProductModel product = e.Product;
                ProductsDataAccess.Update(product);

                MessageBox.Show("Item has been edited");
            }

            InitializeData();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageProductsForm_Load(object sender, EventArgs e)
        {
            isFormLoaded = true;
        }
    }
}
