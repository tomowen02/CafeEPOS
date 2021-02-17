using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.Models
{
    public class TransactionModel
    {
        public int TransactionID { get; set; }
        public string Date { get; set; }
        public decimal Total { get; set; }
        public decimal Change { get; set; }
        public string PaymentMethod { get; set; }
        public string EmployeeUsername { get; set; }
    }
}
