using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Windows.Forms;

namespace ChapeauLogic
{
    public class OrderServices
    {
        OrderDAO orderdao = new OrderDAO();


        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            try
            {
                orders = orderdao.GetAllOrders();
                return orders;
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
                return orders;
            }
        }
        public List<OrderItem> GetKitchenOrderItems(int id)
        {
            List<OrderItem> orders = new List<OrderItem>();
            try
            {
                orders = orderdao.GetKitchenItems(id);
                return orders;
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
                return orders;
            }
        }
        public List<OrderItem> GetBarOrderItems(int id)
        {
            List<OrderItem> orders = new List<OrderItem>();
            try
            {
                orders = orderdao.GetBarItems(id);
                return orders;
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
                return orders;
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
            int row = this.orderdao.WriteOrder(order);
            //error here about a steak  when I tried to ad 2 of them.
            Order ord = this.orderdao.GetLastOrder();
            foreach (OrderItem item in order.OrderItems)
            {
                // send the int order id
                this.orderdao.WriteOrderItems(ord, item);
            }


            return row;
        }

        public List<OrderItem> GetKitchenTableItems(int id)
        {
            List<OrderItem> orders = new List<OrderItem>();
            try
            {
                orders = orderdao.GetKitchenItemsPerTable(id);
                return orders;
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
                return orders;
            }
        }
        public List<OrderItem> GetBarTableItems(int id)
        {
                List<OrderItem> orders = new List<OrderItem>();
            try
            {
                orders = orderdao.GetBarItemsPerTable(id);
                return orders;
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
                return orders;
            }
        }
        public bool OrderReady(int id)
        {
            try
            {
                orderdao.UpdateReady(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string GetComments(int id)
        {
            try
            {
                return orderdao.GetComment(id);
            }
            catch
            {
                return "";
            }
        }

        public bool CheckStatusReady(int id)
        {
            List<int> status = new List<int>();
            status = orderdao.GetStatus(id);
            foreach (int state in status)
            {
                if (state != 2)
                    return false;
            }
            return true;
        }
        public bool OrderCompeteReady(int id)
        {
            try
            {
                orderdao.OrderReady(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
