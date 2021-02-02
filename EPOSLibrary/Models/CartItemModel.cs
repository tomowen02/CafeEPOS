using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.Models
{
    public class CartItemModel
    {
        private ProductModel product;
        public ProductModel Product
        {
            get { return product; }
            set 
            {
                UnitPrice = value.Price;
                product = value;
            }
        }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal TotalPrice { get { return UnitPrice * Quantity; } }
    }
}
