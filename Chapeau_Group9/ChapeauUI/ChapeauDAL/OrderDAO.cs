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
            SqlCommand cmd = new SqlCommand("INSERT INTO OrderFabio(employee_ID, table_ID, order_time, total)" +
                "VALUES(@empid, @orderid, '@time', @total);", conn);

            cmd.Parameters.AddWithValue("@empid", order.Employee.EmployeeID);
            cmd.Parameters.AddWithValue("@orderid", order.OrderID);
            cmd.Parameters.AddWithValue("@time", DateTime.Now);
            cmd.Parameters.AddWithValue("@total", order.TotalPrice);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();


            return rows;
        }
        public int WriteOrderItems(Order order)
        {


            string query = "INSERT INTO OrderItemFabio(order_id, article_id, quantity, totalPrice) VALUES";

            foreach (OrderItem item in order.OrderItems)
            {
                query += $"({order.OrderID}, {item.MenuItem.MenuItemID}, {item.Quantity}, {item.TotaPrice}),";
            }

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();


            return row;
        }
    }
}
