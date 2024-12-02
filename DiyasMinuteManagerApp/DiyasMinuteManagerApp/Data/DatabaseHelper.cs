using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DiyasMinuteManagerApp.Data
{
    public static class DatabaseHelper
    {
        // Static field to store the connection string
        private static readonly string connectionString;
        // Static constructor to initialize the connection string
        static DatabaseHelper()
        {
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["DiyaMinuteFinal"]?.ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("Connection string 'DiyaMinuteFinal' is not found in the configuration file.");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error initializing database connection: " + ex.Message, ex);
            }
        }


        // Method to get a new SQL connection instance
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Execute a non-query command (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    using (var cmd = new SqlCommand(commandText, conn))
                    {
                        cmd.CommandType = commandType;
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("ExecuteNonQuery", commandText, ex);
                throw;
            }
        }

        // Execute a command that returns a single value
        public static object ExecuteScalar(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    using (var cmd = new SqlCommand(commandText, conn))
                    {
                        cmd.CommandType = commandType;
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("ExecuteScalar", commandText, ex);
                throw;
            }
        }

        // Execute a query that returns multiple rows (e.g., SELECT)
        public static DataTable ExecuteQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        conn.Open();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        // Method to log errors for troubleshooting
        private static void LogError(string methodName, string commandText, Exception ex)
        {
            // Implement logging here (e.g., log to a file, database, or monitoring system)
            Console.WriteLine($"Error in {methodName}. Command: {commandText}. Exception: {ex.Message}");
        }
    }
}
    
