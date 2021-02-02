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
    public partial class EditProductTypeInfoForm : Form
    {
        private ProductTypeModel ExistingType { get; set; }
        public bool IsNewType { get; set; }

        public delegate void ProductTypeGeneratedEvent(object sender, ProductTypeGeneratedEventArgs e);
        public event ProductTypeGeneratedEvent ProductTypeGenerated;

        public EditProductTypeInfoForm()
        {
            InitializeComponent();

            ExistingType = null;
            IsNewType = true;
        }

        public EditProductTypeInfoForm(ProductTypeModel type)
        {
            InitializeComponent();

            ExistingType = type;
            IsNewType = false;

            FillInData();
        }

        private void FillInData()
        {
            ProductTypeTextbox.Text = ExistingType.ProductType;
            ColourTextbox.Text = ExistingType.Colour;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ProductTypeModel type = new ProductTypeModel();
            type.ProductType = ProductTypeTextbox.Text;
            type.Colour = ColourTextbox.Text;

            if (ExistingType != null)
            {
                type.ProductTypeID = ExistingType.ProductTypeID;
            }

            ProductTypeGenerated(this, new ProductTypeGeneratedEventArgs() { IsNewType = IsNewType, ProductType = type });

            this.Close();
        }
    }

    public class ProductTypeGeneratedEventArgs : EventArgs
    {
        public bool IsNewType { get; set; }
        public ProductTypeModel ProductType { get; set; }
    }
}
