using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public static class Data
    {
        public static SqlConnection OpenConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 24 Class Data)");
                return null;
            }
        }

        public static void CloseConnection(ref SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 37 Class Data)");
            }
        }

        public static SqlDataReader ReadData(string table, SqlConnection connection, 
            string condition, string columns)
        {
            try
            {
                string sqlQuery = "SELECT " + columns + " FROM " + table + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                return command.ExecuteReader();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 52 Class Data)");
                return null;
            }
        }

        public static void AddData(string table, string value)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                string sqlQuery = "INSERT INTO " + table + " VALUES (" + value + ")";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                Data.CloseConnection(ref connection);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 69 Class Data)");
            }
        }

        public static void DeleteData(string table, string condition)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                string sqlQuery = "DELETE FROM " + table + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                Data.CloseConnection(ref connection);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 85 Class Data)");
            }
        }

        public static void UpdateData(string table, string update, string condition)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                string sqlQuery = "UPDATE " + table + " SET " + update + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                Data.CloseConnection(ref connection);
            }
            catch (Exception e)
            {
                IO.ExportError("Lỗi không xác định\n(Line 101 Class Data)");
            }
        }

        public static void ExeQuery(string query, SqlConnection connection)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 114 Class Data)");
            }
        }

        public static int Calculate(string type, string column, string tables, string condition)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                Data.ExeQuery("SET DATEFORMAT DMY", connection);
                string sqlQuery = "SELECT " + type + "(" + column + ") FROM " + tables + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                int result;

                try
                {
                    result = (int)command.ExecuteScalar();
                }
                catch (InvalidCastException)
                {
                    result = 0;
                }

                Data.CloseConnection(ref connection);
                return result;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 142 Class Data)");
                return -1;
            }
        }
    }
}
