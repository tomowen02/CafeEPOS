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
    public class TransactionsDataAccess : Connection<TransactionModel>
    {
        public static List<TransactionModel> Load()
        {
            string query = "SELECT TransactionID, Date, Total /100.0 AS Total, Change /100.0 AS Change, PaymentMethod, EmployeeUsername FROM Transactions";

            return Query(query);
        }

        public static TransactionModel Save(TransactionModel transaction)
        {
            string query = "INSERT INTO Transactions (Date, Total, Change, PaymentMethod, EmployeeUsername) " +
                "VALUES (@Date, @Total * 100, @Change * 100, @PaymentMethod, @EmployeeUsername); " +
                "SELECT last_insert_rowid()";

            var parameters = new DynamicParameters();
            parameters.Add("@Date", transaction.Date);
            parameters.Add("@Total", transaction.Total);
            parameters.Add("@Change", transaction.Change);
            parameters.Add("@PaymentMethod", transaction.PaymentMethod);
            parameters.Add("@EmployeeUsername", transaction.EmployeeUsername);

            var id = Int32.Parse(ExecuteScalar(query, parameters));
            transaction.TransactionID = id;
            return transaction;
        }

        public static void CreateTable()
        {
            string query = @"
                CREATE TABLE Transactions (
                    TransactionID
                        INTEGER
                        PRIMARY KEY AUTOINCREMENT
                        UNIQUE
                        NOT NULL,
                    Date
                        DATETIME
                        NOT NULL,
                    Total
                        INTEGER
                        NOT NULL,
                    Change
                        INTEGER
                        NOT NULL,
                    PaymentMethod
                        STRING
                        NOT NULL,
                    EmployeeUsername
                        STRING
                        NOT NULL
                        REFERENCES Employees (EmployeeUsername) 
                );";

            Execute(query);
        }
    }
}
