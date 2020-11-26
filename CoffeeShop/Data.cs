using System;
using System.Collections.Generic;
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
            string connectionString = @"Server=DESKTOP-AE2J3P4\LEHOANGPHU; Database=QLQCP; User Id=sa;
                Password=13012001;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static void CloseConnection(ref SqlConnection connection)
        {
            connection.Close();
        }

        public static SqlDataReader ReadData(string table, SqlConnection connection, 
            string condition, string columns)
        {
            string sqlQuery = "SELECT " + columns + " FROM " + table + condition;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            return command.ExecuteReader();
        }

        public static void AddData(string table, string value)
        {
            SqlConnection connection = Data.OpenConnection();
            string sqlQuery = "INSERT INTO " + table + " VALUES (" + value + ")";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            Data.CloseConnection(ref connection);
        }

        public static void DeleteData(string table, string condition)
        {
            SqlConnection connection = Data.OpenConnection();
            string sqlQuery = "DELETE FROM " + table + condition;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            Data.CloseConnection(ref connection);
        }

        public static void UpdateData(string table, string update, string condition)
        {
            SqlConnection connection = Data.OpenConnection();
            string sqlQuery = "UPDATE " + table + " SET " + update + condition;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            Data.CloseConnection(ref connection);
        }
    }
}
