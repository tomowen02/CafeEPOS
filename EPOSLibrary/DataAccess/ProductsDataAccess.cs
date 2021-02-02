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
    public class ProductsDataAccess : ConnectionString
    {
        // TODO - Inner join for product type

        #region Load Products
        private static List<ProductModel> SendQuery(string query, DynamicParameters parameters)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>(query, parameters);
                return output.ToList();
            }
        }

        public static ProductModel LoadSingle(int id)
        {
            string query = "SELECT ProductID, Description, ProductTypeID, Price/100.0 AS Price FROM Products WHERE ProductID = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            return SendQuery(query, parameters).First();
        }

        public static List<ProductModel> Load(string searchTerm = "", int typeID = -1, decimal minPrice = -1, decimal maxPrice = -1)
        {
            string query = "SELECT ProductID, Description, ProductTypeID, Price/100.0 AS Price FROM Products";

            List<string> conditions = new List<string>();
            var parameters = new DynamicParameters();

            if (searchTerm != "")
            {
                conditions.Add("Description LIKE '%' || @searchTerm || '%'");
                parameters.Add("@searchTerm", searchTerm);
            }
            if (typeID != -1)
            {
                conditions.Add("ProductTypeID = @typeID");
                parameters.Add("@typeID", typeID);
            }
            if (minPrice != -1)
            {
                minPrice *= 100;
                conditions.Add("Price >= @minPrice");
                parameters.Add("@minPrice", minPrice);
            }
            if (maxPrice != -1)
            {
                maxPrice *= 100;
                conditions.Add("Price <= @maxPrice");
                parameters.Add("@maxPrice", maxPrice);
            }

            for (int i = 0; i < conditions.Count; i++)
            {
                if (i == 0)
                {
                    query += " WHERE";
                }
                else
                {
                    query += " AND";
                }
                query += ' ' + conditions[i];
            }

            return SendQuery(query, parameters);



        }
        #endregion

        public static ProductModel Save(ProductModel product)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var id = (int)cnn.ExecuteScalar<int>("INSERT INTO Products (Description, ProductTypeID, Price) VALUES (@Description, @ProductTypeID, @Price * 100); SELECT last_insert_rowid()", product);
                product.ProductID = id;
                return product;
            }
        }

        public static void Update(ProductModel product)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Products SET Description = @Description, ProductTypeID = @ProductTypeID, Price = @Price*100 WHERE ProductID = @ProductID", product);
            }
        }

        public static void Delete(int id)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Products WHERE ProductID = @id", new { id });
            }
        }
    }
}
