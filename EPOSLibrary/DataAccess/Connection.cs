﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.DataAccess
{
    // Shouldn't be inherited
    public class Connection<T>
    {
        /// <summary>
        /// Retrieves the connection string from the global configuration file
        /// </summary>
        /// <param name="id">Specifies which database's connection string is wanted</param>
        /// <returns>Returns the connection string</returns>
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /// <summary>
        /// Executes a parameterised SQL query that will return a single scalar value
        /// </summary>
        /// <param name="query">Specifies the SQL query that  will be executed</param>
        /// <param name="parameters">A DynamicParameters object which will be used for the parameterised SQL query</param>
        /// <returns>A single value of type string</returns>
        public static string ExecuteScalar(string query, DynamicParameters parameters = null)
        {
            if (parameters == null)
            {
                parameters = new DynamicParameters();
            }
            
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = cnn.ExecuteScalar(query, parameters).ToString();

                return result;
            }
        }

        /// <summary>
        /// Executes a parameterised SQL query that will not have a return value
        /// </summary>
        public static void Execute(string query, DynamicParameters parameters = null)
        {
            if (parameters == null)
            {
                parameters = new DynamicParameters();
            }

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(query, parameters);
            }
        }

        /// <summary>
        /// Executes a parameterised SQL query that will return a multile records
        /// </summary>
        /// <returns>A list of objects repesenting rows on a table</returns>
        public static List<T> Query(string query, DynamicParameters parameters = null)
        {
            if (parameters == null)
            {
                parameters = new DynamicParameters();
            }

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<T>(query, parameters);
                return output.ToList();
            }
        }
    }
}
