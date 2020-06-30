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
        public int WriteOrderItems(int orderID, OrderItem item)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO OrderItems(order_ID, article_id, quantity, total_price, comment) VALUES(@id, @aid, @quan, @total, @comment)", conn);
            cmd.Parameters.AddWithValue("@id", orderID);
            cmd.Parameters.AddWithValue("@aid", item.MenuItem.MenuItemID);
            cmd.Parameters.AddWithValue("@quan", item.Quantity);
            cmd.Parameters.AddWithValue("@total", item.TotaPrice);
            cmd.Parameters.AddWithValue("@comment", item.Comment);

            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();


            return row;
        }
        public int GetLastOrderID()
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 order_id FROM [Order] ORDER BY order_ID DESC", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int orderID = (int)reader["order_id"];

            reader.Close();
            conn.Close();

            return orderID;
        }
        public void InsertOrder(Order order)
        {
            OrderItem orderprice = new OrderItem();
            string query = $"INSERT INTO Order(employee_ID, table_ID, order_time, total) VALUES({order.Employee.EmployeeID},{order.Table.TableID},{order.Time},{orderprice.TotaPrice})";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Order> GetAllOrders(MenuItemType type)
        {
            string query = "SELECT DISTINCT [order].order_id, order_time, t.table_id, table_number, Tablestatus, item_type_id " +
                "FROM [order] " +
                "JOIN [tables] AS t ON [order].table_id = t.table_id " +
                "JOIN OrderItems as oi ON [order].order_id = oi.order_id " +
                "JOIN menu as m ON oi.article_id = m.article_id " +
                "WHERE order_status = 1 " +
                $"AND item_type_id {((int)type == 3 ? "=" : "<>")} 3";
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
                    Table = new Table()
                    {
                        TableID = (int)dr["table_id"],
                        TableNumber = (int)dr["table_number"],
                        Status = (TableStatus)dr["Tablestatus"]
                    },
                };
                orders.Add(order);
            }
            return orders;
        }
        public List<OrderItem> GetKitchenBarItems(int id, MenuItemType type)
        {
            string query = "SELECT m.article_id,m.price,m.name,m.category_id,m.item_type_id,m.stock,m.VAT , quantity, item_id, order_time, o.order_id, comment " +
                "FROM OrderItems  " +
                "JOIN menu as m  ON m.article_id = OrderItems.article_id  " +
                "JOIN [order] AS o ON o.order_id = OrderItems.order_id " +
                "WHERE status = 1 " +
                "AND o.order_id = @id " +
                $"AND item_type_id {((int)type == 3 ? " = " : " <> ")} 3";
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
                    MenuItem = new MenuItem()
                    {
                        MenuItemID = (int)dr["article_id"],
                        Name = dr["name"].ToString(),
                        Price = (decimal)dr["price"],
                        Stock = (int)dr["stock"],
                        HighVAT = (bool)dr["VAT"],
                        Type = (MenuItemType)dr["item_type_id"],
                        Category = (CategoryID)dr["category_id"]
                    },
                    Quantity = (int)dr["quantity"],
                    Time = (DateTime)dr["order_time"],
                    OrderId = (int)dr["order_id"],
                    Comment = dr["comment"].ToString()
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

        public string GetComment(int id)
        {
            string query = "SELECT comments FROM [Order] WHERE order_status = 1 AND table_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            return ReadComments(ExecuteSelectQuery(query, sqlParameters));
        }
        private string ReadComments(DataTable dataTable)
        {
            string comment = "";
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    comment += dr["comments"].ToString() + "\n";
                };
            }
            return comment;
        }
        public List<int> GetStatus(int id)
        {
            string query = "select [status] from OrderItems where order_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            return ReadStatus(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<int> ReadStatus(DataTable dataTable)
        {
            List<int> status = new List<int>();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    status.Add((int)dr["status"]);
                };
            }
            return status;
        }

        public void OrderReady(int id)
        {
            string query = "UPDATE [Order] SET order_status = 2 WHERE order_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            ExecuteEditQuery(query, sqlParameters);
        }
        // fabio
        public Order GetRunningOrderForTable(int tableNumber)
        {
            SqlCommand cmd = new SqlCommand("select order_id, employee_id, table_id, order_time, total, order_status from [order] where table_id = @id and order_status <> 4", conn);
            cmd.Parameters.AddWithValue("@id", tableNumber);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Order existingOrder;
            if (reader.Read())
            {
                existingOrder = ReadOrder(reader);
            }
            else
            {
                existingOrder = null;
            }
            conn.Close();
            return existingOrder;
        }
        private Order ReadOrder(SqlDataReader reader)
        {
            Order order = new Order
            {
                OrderID = (int)reader["order_id"],
                OrderStatus = (OrderStatus)reader["order_status"],
                TotalPrice = (decimal)reader["total"],
                Time = (DateTime)reader["order_time"]
            };
            return order;
        }
        public List<OrderItem> GetOrderItemsForTable(int orderID)
        {
            List<OrderItem> items = new List<OrderItem>();
            string query = $"SELECT m.article_id,m.price,m.name,m.category_id,m.item_type_id,m.stock,m.VAT ," +
                $" quantity, item_id, order_time, o.order_id, comment  FROM OrderItems " +
                $"JOIN menu as m  ON m.article_id = OrderItems.article_id " +
                $"JOIN [order] AS o ON o.order_id = OrderItems.order_id  WHERE order_status <> 4 AND o.order_id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", orderID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OrderItem item = ReadOrderItems(reader);
                items.Add(item);
            }
            conn.Close();
            return items;
            //SqlParameter[] sqlParameters = new SqlParameter[1];
            //sqlParameters[0] = new SqlParameter("@id", orderID);
            //return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private OrderItem ReadOrderItems(SqlDataReader reader)
        {
            OrderItem order = new OrderItem()
            {
                OrderItemID = (int)reader["item_id"],
                MenuItem = new MenuItem()
                {
                    MenuItemID = (int)reader["article_id"],
                    Name = reader["name"].ToString(),
                    Price = (decimal)reader["price"],
                    Stock = (int)reader["stock"],
                    HighVAT = (bool)reader["VAT"],
                    Type = (MenuItemType)reader["item_type_id"],
                    Category = (CategoryID)reader["category_id"]
                },
                Quantity = (int)reader["quantity"],
                Time = (DateTime)reader["order_time"],
                OrderId = (int)reader["order_id"],
                Comment = reader["comment"].ToString()
            };
            return order;
        }
    }

}
