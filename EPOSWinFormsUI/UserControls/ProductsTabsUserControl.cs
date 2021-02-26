using EPOSLibrary;
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

namespace EPOSWinFormsUI.UserControls
{
    public partial class ProductsTabsUserControl : UserControl
    {
        readonly int ITEMSPERPAGE = 50;

        public delegate void ProductClickedEvent(object sender, ProductClickedEventArgs e);
        public event ProductClickedEvent ProductClicked;


        public ProductsTabsUserControl()
        {
            InitializeComponent();

            // Ensures that the program is actually in runtime
            // This is needed as an error sometimes occurs where the constructor of a user control
            // is executed during designtime of the control
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                InitializeControl();
            }
        }

        private void InitializeControl()
        {
            List<ProductTypeModel> productTypes = ProductTypesDataAccess.Load();

            // Create a new tab page for each product type
            foreach (var type in productTypes)
            {
                TabPage tab = new TabPage
                {
                    Name = type.ProductTypeID.ToString(),
                    Text = type.ProductType,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Transparent
                };

                FillTab(tab); // Fills the tabs with buttons

                int index = TillTabControl.TabPages.Count;
                TillTabControl.TabPages.Insert(index, tab); // Add the tab to the control


            }

            // For the search tab:
            FillProductTypeComboBox();
            Search();
        }

        private void FillTab(TabPage tab)
        {
            //Use a flow layout panel to visually distribute the buttons
            FlowLayoutPanel ProductsFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            tab.Controls.Add(ProductsFlowPanel);

            // Make a list of all of the product buttons for this tab
            int productTypeID = Int32.Parse(tab.Name);
            List<ProductModel> products = ProductsDataAccess.Load(typeID: productTypeID).MergeSort();
            List<Button> buttonsList = CreateProductButtons(products);

            // Separate the list of all of the buttons into sub pages
            List<List<Button>> productPages = CreateSubPages(ProductsFlowPanel, buttonsList);

            DisplayButtons(ProductsFlowPanel, productPages, (int)ProductsFlowPanel.Tag);
        }

        private List<Button> CreateProductButtons(List<ProductModel> products)
        {
            List<Button> buttonsList = new List<Button>();

            foreach (var product in products)
            {
                Button button = new Button
                {
                    Text = product.Description,
                    Tag = product
                };
                StyleButton(button);
                button.Click += new EventHandler(ProductButton_Clicked);

                buttonsList.Add(button);
            }

            return buttonsList;
        }

        private List<List<Button>> CreateSubPages(FlowLayoutPanel ProductsFlowPanel, List<Button> buttonsList)
        {
            // Each sub page is consists of a list of buttons
            // Therefore, a list of subpages is a list of lists of buttons

            ProductsFlowPanel.Controls.Clear();

            int numberOfProducts = buttonsList.Count;

            var productPages = new List<List<Button>>();
            for (int i = 0; i < numberOfProducts; i++) // For each product
            {
                // Check if this needs to be on a new page
                if (i % ITEMSPERPAGE == 0)
                {
                    var newPage = new List<Button>();

                    // Check if this is NOT the first page
                    if (productPages.Count > 0)
                    {
                        // Add page navigation buttons 

                        Button nextPageButton = new Button
                        {
                            Text = "NEXT PAGE >>"
                        };
                        StyleButton(nextPageButton);
                        nextPageButton.Click += (sender, e) => NextPage_Click(sender, e, ProductsFlowPanel, productPages);
                        productPages.Last().Add(nextPageButton);

                        Button prevPageButton = new Button
                        {
                            Text = "<< PREV PAGE"
                        };
                        StyleButton(prevPageButton);
                        prevPageButton.Click += (sender, e) => PrevPage_Click(sender, e, ProductsFlowPanel, productPages);
                        newPage.Insert(0, prevPageButton);
                    }

                    newPage.Add(buttonsList[i]); // Add the first item of this new page to the page

                    productPages.Add(newPage); // Add this page to the page list
                }
                else
                {
                    // This product will be added to the last existing page
                    productPages.Last().Add(buttonsList[i]);
                }
            }

            if (numberOfProducts == 0)
            {
                // There still needs to be an empty page
                var newPage = new List<Button>();
                productPages.Add(newPage);
            }

            int currentPage = 0;
            ProductsFlowPanel.Tag = currentPage; // This is used to keep track of the current page

            return productPages;
        }

        private void DisplayButtons(FlowLayoutPanel panel, List<List<Button>> pages, int pageIndex)
        {
            panel.Controls.Clear();

            foreach (var button in pages[pageIndex])
            {
                panel.Controls.Add(button);
            }
        }

        private void ProductButton_Clicked(object sender, EventArgs e)
        {
            // Raise the ProductClicked event

            if (ProductClicked == null) return;

            Button button = (Button)sender;
            ProductModel product = (ProductModel)button.Tag;

            ProductClickedEventArgs args = new ProductClickedEventArgs(product);
            ProductClicked(this, args);
        }

        private void NextPage_Click(object sender, EventArgs e, FlowLayoutPanel panel, List<List<Button>> pages)
        {
            int nextPageIndex = (int)panel.Tag + 1;
            DisplayButtons(panel, pages, nextPageIndex);
            panel.Tag = nextPageIndex;
        }

        private void PrevPage_Click(object sender, EventArgs e, FlowLayoutPanel panel, List<List<Button>> pages)
        {
            int prevPageIndex = (int)panel.Tag - 1;
            DisplayButtons(panel, pages, prevPageIndex);
            panel.Tag = prevPageIndex;
        }

        private void StyleButton(Button button)
        {
            button.Margin = new Padding(5, 5, 5, 5);
            button.Width = 125;
            button.Height = 75;
            button.FlatStyle = FlatStyle.Flat;
        }

        #region Search
        private void Search()
        {
            List<ProductModel> products;

            // Get the search parameters from the input boxes
            string searchText = TillTabControl.TabPages["search"].Controls["SearchTextbox"].Text.Trim();
            ComboBox combo = (ComboBox)TillTabControl.TabPages["search"].Controls["productTypeComboBox"];
            int typeID = ((ProductTypeModel)combo.SelectedItem).ProductTypeID;

            // Use the data access to filter the results
            if (FilterByTypeCheckBox.Checked)
            {
                products = ProductsDataAccess.Load(searchTerm: searchText, typeID: typeID);
            }
            else
            {
                products = ProductsDataAccess.Load(searchTerm: searchText);
            }

            products = products.MergeSort(); // Sort the products in alphanumerical order

            // Create and display the buttons
            List<Button> buttonsList = CreateProductButtons(products);
            FlowLayoutPanel SearchProductsFlowPanel = (FlowLayoutPanel)TillTabControl.TabPages["search"].Controls["SearchProductsFlowPanel"];

            List<List<Button>> productPages = CreateSubPages(SearchProductsFlowPanel, buttonsList);
            DisplayButtons(SearchProductsFlowPanel, productPages, (int)SearchProductsFlowPanel.Tag);
        }

        private void FillProductTypeComboBox()
        {
            ComboBox productTypeComboBox = (ComboBox)TillTabControl.TabPages["search"].Controls["productTypeComboBox"];
            productTypeComboBox.SelectedIndexChanged -= new EventHandler(ProductTypeComboBox_Changed);
            List<ProductTypeModel> productTypes = ProductTypesDataAccess.Load();
            productTypeComboBox.DataSource = productTypes;
            productTypeComboBox.DisplayMember = "ProductType";
            productTypeComboBox.SelectedIndexChanged += new EventHandler(ProductTypeComboBox_Changed);
        }

        private void SearchBox_Changed(object sender, EventArgs e)
        {
            Search();
        }

        private void FilterByTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void ProductTypeComboBox_Changed(object sender, EventArgs e)
        {
            FilterByTypeCheckBox.Checked = true;
            Search();
        }
        #endregion

        
    }

    public class ProductClickedEventArgs : EventArgs
    {
        public ProductModel Product { get; set; }

        public ProductClickedEventArgs(ProductModel product)
        {
            Product = product;
        }
    }
}
