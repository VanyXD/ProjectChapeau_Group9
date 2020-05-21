using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderServices
    {
        OrderDAO order = new OrderDAO();

        public List<Order> GetArticles()
        {
            try
            {
                List<Order> orders = new List<Order>();
                orders = order.GetAllOrders();
                return orders;
            }
            catch (Exception)
            {
                List<Order> orders = new List<Order>();
                Order order1 = new Order();
                order1.EmployeeID = 00000;
                order1.OrderID = 11111;
                order1.TotalPrice = 00000;
                order1.Items = null;
                order1.Time = DateTime.Now;
                order1.TableID = 0000;
                order1.OrderStatus = OrderStatus.empty; 

                orders.Add(order1);
                return orders;
                throw new Exception("Couldn't connect to the database");

            }
        }
    }
}
