using ChapeauModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;

namespace ChapeauDAL
{
    public class TablesDAO : Base
    {
        private SqlConnection dbConnection;
        public TablesDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        public List<Tables> GetALLTables()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT table_id,TableStatus,table_number FROM tables", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Tables> tables = new List<Tables>();
            while (reader.Read())
            {
                Tables table = ReadTables(reader);
                tables.Add(table);
            }
            reader.Close();
            dbConnection.Close();
            return tables;
        }
        private Tables ReadTables(SqlDataReader reader)
        {
            int TableID = (int)reader["table_id"];
            TableStatus Status = (TableStatus)reader["TableStatus"];
            int TableNumber = (int)reader["table_number"];
            return new Tables(TableID, Status, TableNumber);
        }
        public void UpdateTableStatus(Tables table)
        {
            SqlCommand cmd = new SqlCommand("update [tables] set Tablestatus = @stat where table_id = @id", conn);

            cmd.Parameters.AddWithValue("@id", table.TableID);
            cmd.Parameters.AddWithValue("@stat", table.Status);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Order> ReadAllOrders()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT  order_status FROM [Order]", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Order> orders = new List<Order>();
            while (reader.Read())
            {
                Order order1 = ReadOrder(reader);
                orders.Add(order1);
            }
            reader.Close();
            dbConnection.Close();
            return orders;
        }
        public Order ReadOrder(SqlDataReader reader)
        {
            Order order = new Order
            {
                OrderStatus = (OrderStatus)reader["order_status"],
            };
            return order;
        }
        //public List<Order> GetAllOrderTime()
        //{
        //    dbConnection.Open();
        //    SqlCommand cmd = new SqlCommand($"SELECT DISTINCT order_time FROM [Order] ", dbConnection);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    List<Order> orders = new List<Order>();
        //    while (reader.Read())
        //    {
        //        Order order1 = ReadOrderTime(reader);
        //        orders.Add(order1);
        //    }
        //    reader.Close();
        //    dbConnection.Close();
        //    return orders;
        //}
        //public Order ReadOrderTime(SqlDataReader reader)
        //{
        //    Order order = new Order
        //    {
        //        Time = (DateTime)reader["order_time"]
        //    };
        //    return order;
        //}

    }
}






