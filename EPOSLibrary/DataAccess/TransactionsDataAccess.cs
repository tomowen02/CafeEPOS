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
    public class TransactionsDataAccess : ConnectionString
    {
        public static List<TransactionModel> Load()
        {
            string query = "SELECT TransactionID, Date, Total /100.0 AS Total, Change /100.0 AS Change, PaymentMethod, EmployeeUsername FROM Transactions";
            var parameters = new DynamicParameters();


            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TransactionModel>(query, parameters);
                return output.ToList();
            }
        }

        public static TransactionModel Save(TransactionModel transaction)
        {
            string query = "INSERT INTO Transactions (Date, Total, Change, PaymentMethod, EmployeeUsername) " +
                "VALUES (@Date, @Total * 100, @Change * 100, @PaymentMethod, @EmployeeUsername); " +
                "SELECT last_insert_rowid()";

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var id = (int)cnn.ExecuteScalar<int>(query, transaction);
                transaction.TransactionID = id;
                return transaction;
            }
        }
    }
}
