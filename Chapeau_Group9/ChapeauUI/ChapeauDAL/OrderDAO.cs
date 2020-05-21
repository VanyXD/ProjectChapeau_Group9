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
        public List<Order> GetAllOrders()
        {
            {
                string query = "SELECT EmployeeID, OrderID, TotalPrice, Items, Time, TableID, OrderStatus FROM [Order]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
            }
        }
        private List<Order> ReadOrder(DataTable datatable)
        {
            List<Order> orderList = new List<Order>();
            foreach (DataRow dr in datatable.Rows)
            {
                Order order = new Order()
                {
                    EmployeeID = (int)dr["EmployeeID"],
                    OrderID = (int)dr["OrderID"],
                    TotalPrice = (decimal)dr["TotalPrice"],
                    Items = (MenuItem)dr["Name"],
                    Time = (DateTime)dr["Time"],
                    TableID = (int)dr["TableID"],
                    OrderStatus = (OrderStatus)dr["OrderStatus"]
                };
                orderList.Add(order);
            }
            return orderList;
        }

        public void AddOrder(Order order)
        {
            string query = $"insert into Orders(order_id,quantity,order_time,total,employees_id,article_id,table_id) values({order.OrderID}, {order.Quantity}, {order.Time}, " +
                $"{order.TotalPrice}, {order.EmployeeID}, {order.Items.MenuItemID}, {order.TableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemoveOrder(Order order)
        {
            string query = $"Delete from orders where order_id = {order.OrderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
