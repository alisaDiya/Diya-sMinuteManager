using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyasMinuteManagerApp.Data
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString;
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

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

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


        private static void LogError(string methodName, string commandText, Exception ex)
        {
            // Implement logging here (e.g., log to a file, database, or monitoring system)
            Console.WriteLine($"Error in {methodName}. Command: {commandText}. Exception: {ex.Message}");
        }
    }
}
    
