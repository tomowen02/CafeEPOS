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
    public class ProductTypesDataAccess : Connection<ProductTypeModel>
    {
        public static List<ProductTypeModel> Load(string searchTerm = "")
        {
            string query = "SELECT ProductTypeID, ProductType, Colour FROM ProductTypes";
            
            var parameters = new DynamicParameters();

            if (searchTerm != "")
            {
                query += " WHERE ProductType LIKE '%' || @searchTerm || '%'";
                parameters.Add("@searchTerm", searchTerm);
            }

            return Query(query, parameters);
        }

        public static ProductTypeModel LoadSingle(int id)
        {
            string query = "SELECT ProductTypeID, ProductType, Colour FROM ProductTypes WHERE ProductTypeID = @id";
            
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            return Query(query, parameters).First();
        }

        public static void Save(ProductTypeModel productType)
        {
            string query = "INSERT INTO ProductTypes (ProductType, Colour) VALUES (@ProductType, @Colour)";

            var parameters = new DynamicParameters();
            parameters.Add("@ProductType", productType.ProductType);
            parameters.Add("@Colour", productType.Colour);
            Execute(query, parameters);
        }

        public static void Update(ProductTypeModel productType)
        {
            string query = "UPDATE ProductTypes SET ProductType = @ProductType, Colour = @Colour WHERE ProductTypeID = @ProductTypeID";

            var parameters = new DynamicParameters();
            parameters.Add("@ProductTypeID", productType.ProductTypeID);
            parameters.Add("@ProductType", productType.ProductType);
            parameters.Add("@Colour", productType.Colour);

            Execute(query, parameters);
        }

        public static void Delete(int id)
        {
            string query = "DELETE FROM ProductTypes WHERE ProductTypeID = @ProductTypeID";

            var parameters = new DynamicParameters();
            parameters.Add("@ProductTypeID", id);

            Execute(query, parameters);
        }

        public static void CreateTable()
        {
            string query = @"
                CREATE TABLE ProductTypes (
                    ProductTypeID
                        INTEGER
                        PRIMARY KEY AUTOINCREMENT
                        NOT NULL
                        UNIQUE,
                    ProductType
                        STRING
                        NOT NULL
                        UNIQUE,
                    Colour
                        STRING
                );";

            Execute(query);
        }
    }
}
