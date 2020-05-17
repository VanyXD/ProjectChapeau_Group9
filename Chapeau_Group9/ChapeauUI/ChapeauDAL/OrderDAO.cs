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
        private SqlConnection conn;
        public List<Order> GetAll()
        {
            List<Order> orders = new List<Order>();
            SqlCommand cmd = new SqlCommand("SELECT O.order_id, O.quantity, O.order_time, O.total, " +
                "E.employee_id, E.first_name, E .last_name, E.phone, E.[password], E.position_id, " +
                "M.article_id, M.[name], M.stock, M.VAT, M.lunch, M.price, M.category_ID FROM orders " +
                "AS O JOIN employees AS E ON E.employee_id = O.employees_id JOIN menu AS M ON " +
                "M.article_ID = O.article_id", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Order order = ReadOrder(reader);
                orders.Add(order);

            }
            reader.Close();
            dbConnection.Close();
            return orders;
        }
        private Order ReadOrder(SqlDataReader reader)
        {
            Order order = new Order();

            Employee employee = new Employee();

            MenuItem item = new MenuItem();

            employee.FirstName = (string)reader["first_name"];
            employee.LastName = (string)reader["last_name"];
            employee.EmployeeID = (int)reader["employee_id"];

            order.Employee = employee;

            item.MenuItemID = (int)reader["article_id"];
            item.Name = (string)reader["name"];
            item.Price = (decimal)reader["price"];
            return order;
        }
    }
}
