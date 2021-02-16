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
    public partial class EditProductInfoForm : Form
    {
        private ProductModel ExistingProduct { get; set; }
        public bool IsNewItem { get; set; }

        public delegate void ProductGeneratedEvent(object sender, ProductGeneratedEventArgs e);
        public event ProductGeneratedEvent ProductGenerated;

        public EditProductInfoForm()
        {
            InitializeComponent();

            InitializeCombo();

            ExistingProduct = null;
            IsNewItem = true;
        }

        public EditProductInfoForm(ProductModel product)
        {
            InitializeComponent();

            InitializeCombo();

            ExistingProduct = product;
            IsNewItem = false;

            FillInData();
        }

        private void InitializeCombo()
        {
            List<ProductTypeModel> productTypes = ProductTypesDataAccess.Load();
            ProductTypeComboBox.DataSource = productTypes;
            ProductTypeComboBox.DisplayMember = "ProductType";
        }

        private void FillInData()
        {
            // Find ProductType item in ComboBox
            object comboBoxItem = null;
            foreach (var item in ProductTypeComboBox.Items)
            {
                if (((ProductTypeModel)item).ProductTypeID == ExistingProduct.ProductTypeID)
                {
                    comboBoxItem = item;
                    break;
                }
            }

            // Fill out the data into input boxes
            ProductDescriptionTextbox.Text = ExistingProduct.Description;
            if (comboBoxItem != null)
            {
                ProductTypeComboBox.SelectedItem = comboBoxItem;
            }
            PriceTextbox.Text = ExistingProduct.Price.ToString("0.00");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ProductDescriptionTextbox.Text != "" & PriceTextbox.Text != "")
            {
                ProductModel product = new ProductModel();
                product.Description = ProductDescriptionTextbox.Text;
                product.ProductTypeID = ((ProductTypeModel)ProductTypeComboBox.SelectedItem).ProductTypeID;
                product.Price = Decimal.Parse(PriceTextbox.Text);

                if (ExistingProduct != null)
                {
                    product.ProductID = ExistingProduct.ProductID;
                }

                ProductGenerated(this, new ProductGeneratedEventArgs() { IsNewItem = IsNewItem, Product = product });

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid values");
            }
            
        }
    }

    public class ProductGeneratedEventArgs : EventArgs
    {
        public bool IsNewItem { get; set; }
        public ProductModel Product { get; set; }
    }
}
