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
    public partial class ManageProductTypesForm : Form
    {
        public ManageProductTypesForm()
        {
            InitializeComponent();

            UpdateData();
        }

        private void UpdateData( string searchTerm = "")
        {
            var productTypes = ProductTypesDataAccess.Load(searchTerm);

            ProductTypesDataGridView.DataSource = productTypes;
        }

        private void Search(object sender, EventArgs e)
        {
            UpdateData(TypeSearchTextBox.Text.Trim());
        }

        private ProductTypeModel GetSelectedType()
        {
            return (ProductTypeModel)ProductTypesDataGridView.SelectedRows[0].DataBoundItem;
        }

        private void NewTypeButton_Click(object sender, EventArgs e)
        {
            EditProductTypeInfoForm editProductTypeInfoForm = new EditProductTypeInfoForm();
            editProductTypeInfoForm.ProductTypeGenerated += new EditProductTypeInfoForm.ProductTypeGeneratedEvent(NewOrEditedType);
            editProductTypeInfoForm.StartPosition = FormStartPosition.CenterParent;

            try
            {
                editProductTypeInfoForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void EditTypeButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ProductTypesDataGridView.SelectedRows[0].Cells["ProductTypeID"].Value.ToString());
            ProductTypeModel type = ProductTypesDataAccess.LoadSingle(id);


            EditProductTypeInfoForm editProductTypeInfoForm = new EditProductTypeInfoForm(type);
            editProductTypeInfoForm.ProductTypeGenerated += new EditProductTypeInfoForm.ProductTypeGeneratedEvent(NewOrEditedType); //new
            editProductTypeInfoForm.StartPosition = FormStartPosition.CenterParent;

            try
            {
                editProductTypeInfoForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void DeleteTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productTypeID = GetSelectedType().ProductTypeID;
                ProductTypesDataAccess.Delete(productTypeID);

                MessageBox.Show("Product type has been deleted");
            }
            catch
            {

                MessageBox.Show("Something went wrong");
            }

            UpdateData();
        }

        private void NewOrEditedType(object sender, ProductTypeGeneratedEventArgs e)
        {
            if (e.IsNewType)
            {
                ProductTypeModel type = e.ProductType;
                ProductTypesDataAccess.Save(type);

                MessageBox.Show("New product type has been saved");
            }
            else
            {
                ProductTypeModel type = e.ProductType;
                ProductTypesDataAccess.Update(type);

                MessageBox.Show("The product type has been updated");
            }

            UpdateData();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
