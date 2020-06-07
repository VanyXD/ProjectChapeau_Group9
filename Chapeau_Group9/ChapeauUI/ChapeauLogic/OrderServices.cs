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
            int roww = this.order.WriteOrderItems(order);
            if (row > 0 && roww > 0)
            {
                return row;
            }


            return -1;
        }
    }
}
