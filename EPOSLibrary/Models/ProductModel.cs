using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EPOSLibrary.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public int ProductTypeID { get; set; }
        public decimal Price { get; set; }
        public bool isActive { get; set; }
    }
}
