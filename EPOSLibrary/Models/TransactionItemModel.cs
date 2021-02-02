using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.Models
{
    public class TransactionItemModel
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal CurrentUnitPrice { get; set; }
    }
}
