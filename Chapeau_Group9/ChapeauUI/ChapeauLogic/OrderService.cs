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
    public class OrderService
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
        public int WriteOrder(Order order, Table table) // make it a boolean
        {
            try
            {
                TablesDAO tabledao = new TablesDAO();
                table.Status = TableStatus.Occupied; // change table state to occupied
                tabledao.UpdateTableStatus(table); // update table state
                int row = this.orderdao.WriteOrder(order); // write order


                int orderID = this.orderdao.GetLastOrderID();
                int oirows = 0;
                foreach (OrderItem item in order.OrderItems) 
                {
                    // send the int order id
                    oirows = this.orderdao.WriteOrderItems(orderID, item);
                } // we cant write the order and order items 
                  //simultaneousely because the orderid in the order table is identity and 
                  //db decides for it's value, on the other hand orderid is referenced as a 
                  //foreign key in the orderitems table, so if we dont have the orderid we 
                  //cant write the order items, on the other hand some orders might be deleted 
                  //so just trying to guess the orderid in c# and calculating it wont alway work
                  // that is why we have to first write the order, let the db choose the orderid for the
                  //entire order, then get it back from db (line 69) and write the orderitems using that orderid
                  // and we have a list of orderitems that all of them need to be written to the db, so we use a foreach
                  // and foreach orderitem in the orderitems list of the order, we write it's menuitem and quantity in the db
                  // I talked too much again, didnt I?! :(
                if (oirows > 0)
                {
                    return row;
                }
                return -1;
            }
            catch (Exception)
            {
                return -2;
            }
            
            
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
