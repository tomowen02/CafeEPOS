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
    public class TransactionItemsDataAccess : Connection<TransactionItemModel>
    {
        public static List<TransactionItemModel> Load(int transactionID)
        {
            string query = "SELECT TransactionID, ProductID, Quantity, CurrentUnitPrice/100.0 AS CurrentUnitPrice " +
                "FROM TransactionItems " +
                "WHERE TransactionID = @TransactionID;";

            var parameters = new DynamicParameters();
            parameters.Add("@TransactionID", transactionID);

            return Query(query, parameters);
        }

        public static void Save(TransactionItemModel transactionItem)
        {
            string query = "INSERT INTO TransactionItems (TransactionID, ProductID, Quantity, CurrentUnitPrice) " +
                "VALUES (@TransactionID, @ProductID, @Quantity, @CurrentUnitPrice*100); ";

            var parameters = new DynamicParameters();
            parameters.Add("@TransactionID", transactionItem.TransactionID);
            parameters.Add("@ProductID", transactionItem.ProductID);
            parameters.Add("@Quantity", transactionItem.Quantity);
            parameters.Add("@CurrentUnitPrice", transactionItem.CurrentUnitPrice);

            Execute(query, parameters);
        }

        public static void CreateTable()
        {
            string query = @"
                CREATE TABLE TransactionItems (
                    TransactionID
                        INTEGER
                        NOT NULL
                        REFERENCES Transactions (TransactionID),
                    ProductID
                        INTEGER
                        NOT NULL
                        REFERENCES Transactions (TransactionID),
                    Quantity
                        INTEGER
                        NOT NULL,
                    CurrentUnitPrice
                        INTEGER
                        NOT NULL
                );";

            Execute(query);
        }
    }
}
