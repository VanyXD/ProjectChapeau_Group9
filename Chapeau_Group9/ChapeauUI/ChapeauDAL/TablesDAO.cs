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
        public List<Table> GetALLTables()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT table_id,TableStatus,table_number FROM tables ", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Table> tables = new List<Table>();
            while (reader.Read())
            {
                Table table = ReadTables(reader);
                tables.Add(table);
            }
            reader.Close();
            dbConnection.Close();
            return tables;
        }
        private Table ReadTables(SqlDataReader reader)
        {
            int TableID = (int)reader["table_id"];
            TableStatus Status = (TableStatus)reader["TableStatus"];
            int TableNumber = (int)reader["table_number"];
            return new Table(TableID, Status, TableNumber);
        }
        public void UpdateTableStatus(Table table)
        {
            SqlCommand cmd = new SqlCommand("update [tables] set Tablestatus = @stat where table_id = @id", conn);

            cmd.Parameters.AddWithValue("@id", table.TableID);
            cmd.Parameters.AddWithValue("@stat", table.Status);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Order> ReadAllOrders(Order order)
        {         
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT table_id, min(order_time) AS order_time, min(order_status) AS [order_status] FROM [order] WHERE order_status !=4 GROUP BY table_id", dbConnection);
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
                Time = (DateTime)reader["order_time"],
                Table = new Table((int)(reader["table_id"])),
            };
            return order;
        }
    }
}






