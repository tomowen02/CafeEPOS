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
    public class ProductTypesDataAccess : ConnectionString
    {
        #region Load ProductTypes
        private static List<ProductTypeModel> SendQuery(string query, DynamicParameters parameters)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductTypeModel>(query, parameters);
                return output.ToList();
            }
        }

        public static List<ProductTypeModel> Load(string searchTerm = "")
        {
            string query = "SELECT ProductTypeID, ProductType, Colour FROM ProductTypes";
            var parameters = new DynamicParameters();


            if (searchTerm != "")
            {
                query += " WHERE ProductType LIKE '%' || @searchTerm || '%'";
                parameters.Add("@searchTerm", searchTerm);
            }

            return SendQuery(query, parameters);
        }

        public static ProductTypeModel LoadSingle(int id)
        {
            string query = "SELECT ProductTypeID, ProductType, Colour FROM ProductTypes WHERE ProductTypeID = @id";
            var parameters = new DynamicParameters();

            parameters.Add("@id", id);

            return SendQuery(query, parameters).First();
        }
        #endregion

        public static void Save(ProductTypeModel productType)
        {
            // TODO - Return TypeID
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO ProductTypes (ProductType, Colour) VALUES (@ProductType, @Colour)", productType);
            }
        }

        public static void Update(ProductTypeModel productType)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE ProductTypes SET ProductType = @ProductType, Colour = @Colour WHERE ProductTypeID = @ProductTypeID", productType);
            }
        }

        public static void Delete(int id)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM ProductTypes WHERE ProductTypeID = @id", new { id });
            }
        }
    }
}
