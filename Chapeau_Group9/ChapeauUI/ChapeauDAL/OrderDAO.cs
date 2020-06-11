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
            string query = $"INSERT INTO Order(employee_ID, table_ID, order_time, total) VALUES({order.Employee.EmployeeID},{order.Table.TableID},{order.Time},{orderprice.TotaPrice})";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Order> GetAllOrders()
        {
            string query = "select order_id, order_time, table_id from [order] where order_status = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadOrders(DataTable datatable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in datatable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["order_id"],
                    Time = (DateTime)dr["order_time"],
                    Table = new Tables((int)dr["table_id"]),
                };
                orders.Add(order);
            }
            return orders;
        }
        public List<OrderItem> GetKitchenItems(int id)
        {
            string query = "SELECT m.article_id,m.name,m.item_type_id , OrderItems.quantity, item_id, order_time " +
                "FROM OrderItems  " +
                "JOIN menu as m  ON m.article_id = OrderItems.article_id  " +
                "JOIN [order] AS o ON o.order_id = OrderItems.order_id " +
                "WHERE status = 1 " +
                "AND o.order_id = @id " +
                "AND m.item_type_id != 3";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetBarItems(int id)
        {
            string query = "SELECT m.article_id,m.name,m.item_type_id , OrderItems.quantity, item_id, order_time " +
                "FROM OrderItems  " +
                "JOIN menu as m  " +
                "ON m.article_id = OrderItems.article_id  " +
                "JOIN [order] AS o " +
                "ON o.order_id = OrderItems.order_id " +
                "WHERE status = 1 " +
                "AND o.order_id = @id " +
                "AND m.item_type_id = 3";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetKitchenItemsPerTable(int id)
        {
            string query = "SELECT m.article_id,m.name,m.item_type_id , quantity, item_id, order_time " +
                "FROM OrderItems " +
                "JOIN menu as m " +
                "ON m.article_id = OrderItems.article_id " +
                "JOIN [order] as o " +
                "ON o.order_id = OrderItems.order_id " +
                "WHERE status = 1  " +
                "AND table_id = @id " +
                "AND m.item_type_id != 3";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetBarItemsPerTable(int id)
        {
            string query = "SELECT m.article_id,m.name,m.item_type_id , quantity, item_id, order_time " +
                "FROM OrderItems " +
                "JOIN menu as m " +
                "ON m.article_id = OrderItems.article_id " +
                "JOIN [order] as o " +
                "ON o.order_id = OrderItems.order_id " +
                "WHERE status = 1  " +
                "AND table_id = @id " +
                "AND m.item_type_id = 3";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadOrderItems(DataTable datatable)
        {
            List<OrderItem> orders = new List<OrderItem>();
            foreach (DataRow dr in datatable.Rows)
            {
                OrderItem order = new OrderItem()
                {
                    OrderItemID = (int)dr["item_id"],
                    MenuItem = new MenuItem((int)dr["article_id"], dr["name"].ToString()),
                    Quantity = (int)dr["quantity"],
                    Time = (DateTime)dr["order_time"]
                };
                orders.Add(order);
            }
            return orders;
        }
        public void UpdateReady(int id)
        {
            string query = "UPDATE OrderItems SET status = 2 WHERE item_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
