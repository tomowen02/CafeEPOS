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
    public class ProductsDataAccess : Connection<ProductModel>
    {

        /// <summary>
        /// Loads a single product, identified by its ID from the database
        /// </summary>
        public static ProductModel LoadSingle(int id)
        {
            string query = "SELECT ProductID, Description, ProductTypeID, Price/100.0 AS Price, isActive FROM Products WHERE ProductID = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            return Query(query, parameters).First();
        }

        /// <summary>
        /// Loads a list of products that satisfy the filters specified. If no filters are specified, it will be assumed that none are to be applied
        /// </summary>
        public static List<ProductModel> Load(string searchTerm = "", int typeID = -1, decimal minPrice = -1, decimal maxPrice = -1)
        {
            string query = "SELECT ProductID, Description, ProductTypeID, Price/100.0 AS Price, isActive FROM Products WHERE isActive = True";

            List<string> conditions = new List<string>(); // This will store a list of the extra parts of the query specific to each filter
            var parameters = new DynamicParameters();

            // The value of the filter parameters need to be checked if they are the default values
            // If they have been defined and are not the default values, then the condition needs to be added to the conditions list
            if (searchTerm != "")
            {
                conditions.Add("Description LIKE '%' || @searchTerm || '%'"); // the description must contain the search term in any part of the string
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

            // The different conditions must now be concatenated to the end of he query
            for (int i = 0; i < conditions.Count; i++)
            {
                // There has already been previous conditions so the AND operator means that this new condition must also be met
                query += " AND";
                query += ' ' + conditions[i];
            }

            return Query(query, parameters);
        }

        /// <summary>
        /// Saves a product to the database
        /// </summary>
        /// <returns>Returns the same product back, but with the ProductID defined as the automatically generated ID from the database</returns>
        public static ProductModel Save(ProductModel product)
        {
            string query = "INSERT INTO Products (Description, ProductTypeID, Price) VALUES (@Description, @ProductTypeID, @Price * 100); SELECT last_insert_rowid()";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Description", product.Description);
            parameters.Add("@ProductTypeID", product.ProductTypeID);
            parameters.Add("@Price", product.Price);
            
            int id = Int32.Parse(ExecuteScalar(query, parameters));
            product.ProductID = id;
            return product;
        }

        /// <summary>
        /// Updates a specific row in the Product table in the database
        /// </summary>
        public static void Update(ProductModel product)
        {
            string query = "UPDATE Products SET Description = @Description, ProductTypeID = @ProductTypeID, Price = @Price*100 WHERE ProductID = @ProductID";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductID", product.ProductID);
            parameters.Add("@Description", product.Description);
            parameters.Add("@ProductTypeID", product.ProductTypeID);
            parameters.Add("@Price", product.Price);

            Execute(query, parameters);
        }

        /// <summary>
        /// Deletes a row from the products table from the database based on its ProductID
        /// </summary>
        public static void Disable(int id)
        {
            string query = "UPDATE Products SET isActive = False WHERE ProductID = @ProductID";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductID", id);
            Execute(query, parameters);
        }

        /// <summary>
        /// Creates a new Products table in the database
        /// </summary>
        public static void CreateTable()
        {
            string query = @"
                CREATE TABLE Products (
                    ProductID
                        INTEGER PRIMARY KEY AUTOINCREMENT
                        UNIQUE
                        NOT NULL,
                    Description
                        STRING
                        NOT NULL,
                    ProductTypeID
                        STRING
                        NOT NULL
                        REFERENCES ProductTypes (ProductTypeID),
                    Price
                        INTEGER
                        NOT NULL
                );";

            Execute(query);
        }
    }
}
