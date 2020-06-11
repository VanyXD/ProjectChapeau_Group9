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


        public List<Order> GetOrders()
        {
            try
            {
                List<Order> orders = new List<Order>();
                orders = order.GetAllOrders();
                return orders;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public List<OrderItem> GetKitchenOrderItems(int id)
        {
            try
            {
                List<OrderItem> orders = new List<OrderItem>();
                orders = order.GetKitchenItems(id);
                return orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<OrderItem> GetBarOrderItems(int id)
        {
            try
            {
                List<OrderItem> orders = new List<OrderItem>();
                orders = order.GetBarItems(id);
                return orders;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public int WriteOrder(Order order)
        {

            

            decimal hanna = 0;
            foreach (OrderItem item in order.OrderItems)
            {

                hanna += item.TotaPrice;
            }
            order.TotalPrice = hanna;
            int row = this.order.WriteOrder(order);
            //error here about a steak  when I tried to ad 2 of them.
            Order ord = this.order.GetLastOrder();
            foreach(OrderItem item in order.OrderItems)
            {
                // send the int order id
                this.order.WriteOrderItems(ord, item);
            }
            
            if (row > 0)
            {
                return row;
            }


            return row;
        }

        public List<OrderItem> GetKitchenTableItems(int id)
        {
            try
            {
                List<OrderItem> orders = new List<OrderItem>();
                orders = order.GetKitchenItemsPerTable(id);
                return orders;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public List<OrderItem> GetBarTableItems(int id)
        {
            try
            {
                List<OrderItem> orders = new List<OrderItem>();
                orders = order.GetBarItemsPerTable(id);
                return orders;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
    }
}
