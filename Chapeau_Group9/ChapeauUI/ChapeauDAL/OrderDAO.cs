using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;


namespace ChapeauDAL
{
    public class OrderDAO : Base
    {
        public int WriteOrder(Order order)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Order](employee_ID, table_ID, order_time, total, order_status)" +
                "VALUES(@employee_ID, @table_ID, @order_time, @total, @status);", conn);
                                 //^deveria ser table id      
            //cmd.Parameters.AddWithValue("@order_ID", order.OrderID);
            cmd.Parameters.AddWithValue("@employee_ID", order.Employee.EmployeeID); //deveria ser table id
            cmd.Parameters.AddWithValue("@table_ID", order.Table.TableID);
            cmd.Parameters.AddWithValue("@order_time", DateTime.Now); //? to string?
            cmd.Parameters.AddWithValue("@total", order.TotalPrice);
            cmd.Parameters.AddWithValue("@status", order.OrderStatus);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            


            return rows;
        }
        public int WriteOrderItems(Order order, OrderItem item)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO OrderItems(order_ID, article_id, quantity, total_price) VALUES(@id, @aid, @quan, @total)", conn);
            cmd.Parameters.AddWithValue("@id", order.OrderID);
            cmd.Parameters.AddWithValue("@aid", item.MenuItem.MenuItemID);
            cmd.Parameters.AddWithValue("@quan", item.Quantity);
            cmd.Parameters.AddWithValue("@total", item.TotaPrice);

            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();

            
            return row;
        }
        public Order GetLastOrder()
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM [Order] ORDER BY order_ID DESC", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Order order = new Order
            {
                OrderID = (int)reader["order_id"]
            };
            conn.Close();

            return order;
        }
        public void InsertOrder(Order order)  
        {
            OrderItem orderprice = new OrderItem();
            string query = $"INSERT INTO OrderItemFabio(employee_ID, table_ID, order_time, total) VALUES({order.Employee.EmployeeID},{order.Table.TableID},{order.Time},{orderprice.TotaPrice})";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
