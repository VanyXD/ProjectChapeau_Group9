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
                "VALUES(@employee_ID, @table_ID, @order_time, @total);", conn);
                                 //^deveria ser table id      
            //cmd.Parameters.AddWithValue("@order_ID", order.OrderID);
            cmd.Parameters.AddWithValue("@employee_ID", order.Employee.EmployeeID); //deveria ser table id
            cmd.Parameters.AddWithValue("@table_ID", order.Table.TableID);
            cmd.Parameters.AddWithValue("@order_time", DateTime.Now); //? to string?
            cmd.Parameters.AddWithValue("@total", order.TotalPrice);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            


            return rows;
        }
        public int WriteOrderItems(Order order)
        {


            string query = "INSERT INTO OrderItemFabio(employee_ID, table_ID, order_time, total) VALUES";

            foreach (OrderItem item in order.OrderItems)
            {
                query += $"({order.Employee.EmployeeID},{order.Table.TableID},{order.Time},{item.TotaPrice}),";
            }

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();

            
            return row;
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
