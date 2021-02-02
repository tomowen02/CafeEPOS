using Dapper;
using EPOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.DataAccess
{
    public class TransactionItemsDataAccess : ConnectionString
    {
        public static List<TransactionItemModel> Load(int transactionID)
        {
            string query = "SELECT TransactionID, ProductID, Quantity, CurrentUnitPrice " +
                "FROM TransactionItems " +
                "WHERE TransactionID = @TransactionID;";

            var parameters = new DynamicParameters();
            parameters.Add("@TransactionID", transactionID);

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TransactionItemModel>(query, parameters);
                return output.ToList();
            }
        }

        public static void Save(TransactionItemModel transactionItem)
        {
            string query = "INSERT INTO TransactionItems (TransactionID, ProductID, Quantity, CurrentUnitPrice) " +
                "VALUES (@TransactionID, @ProductID, @Quantity, @CurrentUnitPrice); ";

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(query, transactionItem);
            }
        }
    }
}
