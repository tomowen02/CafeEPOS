using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPOSLibrary.Models;
using System.Security.Cryptography.X509Certificates;

namespace EPOSWinFormsUI.UserControls
{
    public partial class ShoppingCartUserControl : UserControl
    {
        //public static List<CartItemModel> CartItems { get; set; }
        public static List<CartItemModel> CartItems = new List<CartItemModel>();

        private decimal total;
        public decimal Total
        {
            get { return total; }
            set 
            {
                total = value;

                // Fire TotalChanged event
                TotalChanged?.Invoke(this, new TotalChangedEventArgs() { Total = value });
            }
        }


        public delegate void TotalChangedEvent(object sender, TotalChangedEventArgs e);
        public event TotalChangedEvent TotalChanged;

        public ShoppingCartUserControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                UpdateCart();
            }
        }

        private void UpdateCart()
        {
            decimal total = 0;

            CartListView.Items.Clear();

            foreach (CartItemModel cartItem in CartItems)
            {
                // Create a new row for the ListView to display the CartItem
                ListViewItem row = new ListViewItem
                {
                    Tag = cartItem,
                    Text = cartItem.Product.Description
                };
                row.SubItems.Add(cartItem.Quantity.ToString());
                row.SubItems.Add(cartItem.UnitPrice.ToString("C2"));
                row.SubItems.Add(cartItem.TotalPrice.ToString("C2"));
                CartListView.Items.Add(row);

                // Update the cart total
                total += cartItem.TotalPrice;

                // Resize column widths
                for (int i = 1; i < CartListView.Columns.Count; i++)
                {
                    CartListView.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }

            Total = total;
        }

        public void Add(ProductModel newProduct, int quantityToAdd = 1)
        {
            bool isNew = true; // Turns true if the poduct is already in the cart

            // Determine if the poduct is already in the cart.
            // If so, the quantity is incremented by 1
            foreach (var cartItem in CartItems)
            {
                if (cartItem.Product.ProductID == newProduct.ProductID)
                {
                    isNew = false;
                    cartItem.Quantity += quantityToAdd;
                    break;
                }
            }

            // Check if the item is new to the cart
            if (isNew)
            {
                CartItemModel newCartItem = new CartItemModel
                {
                    Product = newProduct,
                    Quantity = quantityToAdd
                };
                CartItems.Add(newCartItem);
            }

            UpdateCart();

            // Select the final item row
            int numberOfRows = CartListView.Items.Count;
            CartListView.Items[numberOfRows - 1].Selected = true;
        }

        public int? GetSelectedID()
        {
            if (CartListView.SelectedItems.Count > 0)
            {
                CartItemModel cartItem = (CartItemModel)CartListView.SelectedItems[0].Tag;
                int productID = cartItem.Product.ProductID;
                return productID;
            }

            return null;
        }

        public void Remove(int productID)
        {
            int selectedIndex = CartListView.SelectedIndices[0];

            foreach (var cartItem in CartItems)
            {
                if (cartItem.Product.ProductID == productID)
                {
                    cartItem.Quantity -= 1;

                    if (cartItem.Quantity <= 0)
                    {
                        // There are no more of this product in the cart

                        CartItems.Remove(cartItem);

                        UpdateCart();

                        int lastIndex = CartListView.Items.Count - 1;
                        if (lastIndex > -1) // If there are still any more rows
                        {
                            CartListView.Items[lastIndex].Selected = true;
                        }

                        return;
                    }

                    break;
                }
            }

            // There are still more of the product in the cart

            UpdateCart();

            CartListView.Items[selectedIndex].Selected = true;
        }

        public bool IsEmpty()
        {
            if (CartItems.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Clear()
        {
            CartItems.Clear();
            UpdateCart();
        }

        public List<CartItemModel> GetCartItems()
        {
            return CartItems;
        }
    }

    public class TotalChangedEventArgs : EventArgs
    {
        public decimal Total { get; set; }
    }
}
