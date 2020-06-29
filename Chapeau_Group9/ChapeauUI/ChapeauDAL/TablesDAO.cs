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

        public List<Order> GetAllRunningOrders()
        {         
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT table_id,sum(total) AS total,min(order_id) AS order_id,min(order_time) AS order_time, min(order_status) AS [order_status] FROM [order] WHERE order_status !=4 GROUP BY table_id", dbConnection);
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
                OrderID = (int)reader["order_id"],
                TotalPrice = (decimal)reader["total"],
            };
            return order;
        }
        public Table GetTableForID(int tableID)
        {
            SqlCommand cmd = new SqlCommand("select table_id, table_number, tablestatus from [tables] where table_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", tableID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Table table;
            if (reader.Read())
            {
                table = ReadTables(reader);
            }
            else
            {
                table = null;
            }
            reader.Close();
            conn.Close();
            return table;
        }
    }
}






