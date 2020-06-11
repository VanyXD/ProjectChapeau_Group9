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
                //orders = order.GetAllOrders();
                return orders;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public int WriteOrder(Order order)
        {

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
    }
}
